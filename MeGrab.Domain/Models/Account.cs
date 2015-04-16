using Eagle.Domain;
using System;

namespace MeGrab.Domain.Models
{
    /// <summary>
    /// 代表账户对象
    /// </summary>
    public class Account : EntityBase
    {
        public int UserId { get; set; }

        /// <summary>
        /// 账户金额
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}
