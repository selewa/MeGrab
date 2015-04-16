using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MeGrab.DataObjects
{
    /// <summary>
    /// 领取请求
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class RedPacketSnatchRequest
    {
        /// <summary>
        /// 当前用户所在的聊天群信息，通过聊天群找到对应的红包
        /// </summary>
        [DataMember()]
        public SnatchGroupDataObject SnatchGroup { get; set; }

        /// <summary>
        /// 当前领取红包的用户信息，用于拿到用户的金额账户
        /// </summary>
        [DataMember()]
        public MeGrabUserDataObject Snatcher { get; set; }

        /// <summary>
        /// 得到大红包的Id，以便找到 大红包对应的放置小红包的 消息队列
        /// </summary>
        [DataMember()]
        public string RedPacketGrabActivityId { get; set; }
    }
}
