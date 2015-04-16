using Eagle.Domain.Application;
using MeGrab.Domain.Models;
using System;
using System.Runtime.Serialization;

namespace MeGrab.DataObjects
{
    /// <summary>
    /// 代表用户的数据传输对象
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class MeGrabUserDataObject : DataTransferObjectBase<MeGrabUser>
    {
        [DataMember()]
        public string Name { get; set; }

        [DataMember()]
        public string Email { get; set; }

        [DataMember()]
        public string CellPhoneNo { get; set; }

        protected override void DoMapFrom(MeGrabUser domainModel)
        {
            this.Id = domainModel.Id;
            this.Name = domainModel.Name;
            this.Email = domainModel.Membership.Email;
            this.CellPhoneNo = domainModel.Membership.CellPhoneNo;
        }

        protected override MeGrabUser DoMapTo()
        {
            MeGrabUser user = new MeGrabUser();
            user.Id = this.Id;
            user.Name = this.Name;
            user.Membership.Email = this.Email;
            user.Membership.CellPhoneNo = this.CellPhoneNo;

            return user;
        }
    }
}