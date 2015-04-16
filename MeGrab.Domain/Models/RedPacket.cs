using System;

namespace MeGrab.Domain.Models
{

    /// <summary>
    /// 代表红包实体
    /// </summary>
    public class RedPacket : Giveaway
    {
        /// <summary>
        /// 被分配的金额 通过随机分配或者固定分配的金额
        /// </summary>
        public decimal Amount { get; set; }
    }

}