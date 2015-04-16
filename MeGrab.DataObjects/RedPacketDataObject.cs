using Eagle.Domain.Application;
using MeGrab.Domain.Models;
using System;
using System.Runtime.Serialization;

namespace MeGrab.DataObjects
{
    /// <summary>
    /// 代表红包的传输对象
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class RedPacketDataObject : DataTransferObjectBase<RedPacket, Guid>
    {
        /// <summary>
        /// 被分配的金额 通过随机分配或者固定分配的金额
        /// </summary>
        [DataMember()]
        public decimal Amount { get; set; }

        /// <summary>
        /// 是否已经领取
        /// </summary>
        [DataMember()]
        public bool Snatched
        {
            get
            {
                return this.Snatcher != null &&
                       this.SnatchDateTime != null;
            }
        }

        /// <summary>
        /// 领取人
        /// </summary>
        [DataMember()]
        public MeGrabUserDataObject Snatcher { get; set; }

        /// <summary>
        /// 领取日期时间
        /// </summary>
        [DataMember()]
        public DateTime? SnatchDateTime { get; set; }

        protected override void DoMapFrom(RedPacket domainModel)
        {
            throw new NotImplementedException();
        }

        protected override RedPacket DoMapTo()
        {
            throw new NotImplementedException();
        }
    }
}