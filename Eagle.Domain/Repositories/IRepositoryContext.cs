using Eagle.Core;
using Eagle.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eagle.Domain.Repositories
{
    /// <summary>
    /// The implemented classes are repository transaction contexts
    /// Multiple repositories are included into the same context.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IRepositoryContext: IUnitOfWork, IDisposable
    {
        Guid Id { get; }

        IRepository<TAggregateRoot> GetRepository<TAggregateRoot>() where TAggregateRoot : class, IAggregateRoot<int>, IAggregateRoot, new();

        IRepository<TAggregateRoot, TIdentityKey> GetRepository<TAggregateRoot, TIdentityKey>() where TAggregateRoot : class, IAggregateRoot<TIdentityKey>, new();

        void RegisterAdded(object obj);

        void RegisterModified(object obj);

        void RegisterDeleted(object obj);
    }

}
