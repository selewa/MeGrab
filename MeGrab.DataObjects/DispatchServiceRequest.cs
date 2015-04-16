using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MeGrab.DataObjects
{
    /// <summary>
    /// 派发请求 
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DispatchRequest
    {
        /// <summary>
        /// 当前抢群信息
        /// 1. 获取群Id, 一个群对应N个大红包 
        /// 2. 获取其他成员连接Id或IP，以便能把红包信息推送到他们的客户端
        /// </summary>
        [DataMember()]
        public SnatchGroupDataObject SnatchGroup { get; set; }

        /// <summary>
        /// 大红包信息, 聚合了N个小红包，每个小红包有金额，领取人，领取时间等字段。 
        /// 派发的时候把N个小红包都放置到未领取的红包消息队列
        /// </summary>
        [DataMember()]
        public RedPacketGrabActivityDataObject RedPacketActivity { get; set; }
    }
}
