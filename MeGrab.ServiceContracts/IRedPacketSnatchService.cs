using MeGrab.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MeGrab.ServiceContracts
{
    /// <summary>
    /// 领取红包服务
    /// </summary>
    [ServiceContract]
    public interface IRedPacketSnatchService
    {
        /// <summary>
        /// 领取红包,并返回领取结果ReceiveResponse到领取用户的客户端. 同时用异步的方式
        /// 通过Socket API/SignalR/Html5 web socket 等通信技术让群里的其他成员都能看到该用户领取红包的结果.
        /// </summary>
        [OperationContract()]
        RedPacketSnatchResponse Snatch(RedPacketSnatchRequest receiveRequest);
    }
}
