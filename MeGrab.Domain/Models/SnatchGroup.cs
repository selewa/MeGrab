using Eagle.Domain;
using System;
using System.Collections.Generic;

namespace MeGrab.Domain.Models
{
    /// <summary>
    /// 代表群的聚合
    /// </summary>
    public class SnatchGroup : EntityBase<Guid>, IAggregateRoot<Guid>
    {
        private List<MeGrabUser> members = new List<MeGrabUser>();

        /// <summary>
        /// 群名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 当前群拥有的成员
        /// </summary>
        public IEnumerable<MeGrabUser> Members 
        {
            get 
            {
                return this.members;
            } 
        }

        /// <summary>
        /// 添加成员
        /// </summary>
        public void AddMember(MeGrabUser member) 
        { 
            
        }

        /// <summary>
        /// 移除成员
        /// </summary>
        public void RemoveMembers(MeGrabUser member)
        { 
        
        }
    }
}