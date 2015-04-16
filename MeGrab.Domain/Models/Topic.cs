using Eagle.Domain;
using System;

namespace MeGrab.Domain.Models
{
    /// <summary>
    /// 代表活动的主题，比如抢红包，抢电影票，抢优惠券等
    /// </summary>
    public class Topic : EntityBase<Guid>, IAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Summary { get; set; }
    }
}
