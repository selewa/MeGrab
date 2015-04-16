using MeGrab.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MeGrab.Web.Models
{
    public class SnatchGroupScenarioModel
    {
        public SnatchGroupDataObject Group { get; set; }

        public RedPacketParameterModel RedPacketParameter { get; set; }
    }

    public class RedPacketParameterModel
    {
        public int RedPacketCount { get; set; }

        public decimal TotalAmount { get; set; }

        public string Message { get; set; }

        public string RedPacketType { get; set; }
    }
}