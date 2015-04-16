using Eagle.Core;
using Eagle.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeGrab.Domain.Models
{
    public class RedPacketGrabActivity : GrabActivity<RedPacket>
    {
        public RedPacketGrabActivity() { }

        public RedPacketGrabActivity(int redPacketCount, decimal totalAmount) : 
            this(redPacketCount, totalAmount, DispatchMode.Fixed) { }

        public RedPacketGrabActivity(int redPacketCount, decimal totalAmount, DispatchMode dispatchMode) : 
            this(redPacketCount, totalAmount, dispatchMode, string.Empty) { }

        public RedPacketGrabActivity(int redPacketCount, decimal totalAmount, DispatchMode dispatchMode, string message)
        {
            this.RedPacketCount = redPacketCount;
            this.TotalAmount = totalAmount;
            this.Mode = DispatchMode.Fixed;
            this.Message = message;
        }

        public int RedPacketCount { get; set; }

        public decimal TotalAmount { get; set; }

        public DispatchMode Mode { get; set; }
    }
}
