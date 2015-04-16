using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MeGrab.DataObjects
{
    /// <summary>
    /// 领取结果
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class RedPacketSnatchResponse
    {
        /// <summary>
        /// 收到的金额
        /// </summary>
        [DataMember()]
        public decimal ReceivedAmount { get; set; }

        /// <summary>
        /// 得到最新大红包，可得到剩余的金额，每个红包被领取的信息包括领取人，金额，时间等.
        /// </summary>
        [DataMember()]
        public RedPacketGrabActivityDataObject RedPacketActivity { get; set; }
    }
}
