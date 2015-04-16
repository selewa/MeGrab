using Eagle.Domain.Application;
using MeGrab.Domain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MeGrab.DataObjects
{
    /// <summary>
    /// 代表抢红包/票/优惠券组的数据传输对象
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class SnatchGroupDataObject : DataTransferObjectBase<SnatchGroup, Guid>
    {
        private List<MeGrabUserDataObject> members = new List<MeGrabUserDataObject>();

        [DataMember()]
        public string Name { get; set; }

        [DataMember()]
        public List<MeGrabUserDataObject> Members 
        {
            get
            {
                return this.members;
            }
            set 
            {
                this.members = value;
            }
        }

        protected override void DoMapFrom(SnatchGroup domainModel)
        {
            throw new NotImplementedException();
        }

        protected override SnatchGroup DoMapTo()
        {
            throw new NotImplementedException();
        }
    }
}