﻿using Eagle.Core.IoC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Eagle.Core
{
    /// <summary>
    /// Control how and when instances are created by the Unity container.
    /// </summary>
    public enum ObjectLifetimeMode
    {
        /// <summary>
        ///  Instances are created new every time
        /// </summary>
        Transient,     
        
        /// <summary>
        /// Hold a weak reference to it's managed instance
        /// </summary>
        WeakReferenceRequest,

        /// <summary>
        /// Singleton
        /// </summary>
        Singleton,

        /// <summary>
        /// Keep one instance per thread
        /// </summary>
        InThread,
    }

    public interface IObjectContainer 
    {
        /// <summary>
        /// Initializes the object container by using the application/web config file.
        /// </summary>
        /// <param name="configSectionName">The name of the ConfigurationSection in the application/web config file which is used for initializing the object container.</param>
        /// <param name="configFilePath">The file path of the application/web config file which is used for initializing the object container.</param>
        void InitializeFromConfigFile(string configSectionName, string configFilePath = "");

        /// <summary>
        /// Gets the wrapped container instance.
        /// </summary>
        /// <typeparam name="T">The type of the wrapped container.</typeparam>
        /// <returns>The instance of the wrapped container.</returns>
        T GetWrapperContainer<T>();

        void RegisterType(Type t);

        void RegisterType(Type t, ObjectLifetimeMode lifetime);

        void RegisterType(Type t, string name);

        void RegisterType(Type t, string name, ObjectLifetimeMode lifetime);

        void RegisterType(Type from, Type to, string name);

        void RegisterType(Type from, Type to, string name, ObjectLifetimeMode lifetime);

        void RegisterType<TFrom>(Type to, string name);

        void RegisterType<TFrom>(Type to, string name, ObjectLifetimeMode lifetime);

        void RegisterType<TFrom, TTo>(string name) where TTo : TFrom;

        void RegisterType<TFrom, TTo>(string name, ObjectLifetimeMode lifetime) where TTo : TFrom;

        T Resolve<T>(params ResolverParameter[] parameters);

        T Resolve<T>(string name, params ResolverParameter[] parameters);

        object Resolve(Type t,  params ResolverParameter[] parameters);

        object Resolve(Type t, string name, params ResolverParameter[] parameters);

        IEnumerable<object> ResolveAll(Type t);

        IEnumerable<T> ResolveAll<T>();

        bool Registered(Type t);

        bool Registered(Type t, string name);

        bool Registered<T>();

        bool Registered<T>(string name);

        IEnumerable<Type> TypesFrom { get; }

        IEnumerable<Type> TypesMapTo { get; }
    }
}
