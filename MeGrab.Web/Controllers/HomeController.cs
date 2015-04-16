using MeGrab.DataObjects;
using MeGrab.Web.Filters;
using MeGrab.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MeGrab.Web.Controllers
{
    [SSOAuthorize("http://localhost:8800/Home/Index", new string[] { "SnatchRedPacket" })]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SnatchGroupScenarioModel snatchGroupScenario = new SnatchGroupScenarioModel();

            SnatchGroupDataObject snatchGroup = new SnatchGroupDataObject();
            snatchGroup.Id = Guid.NewGuid();
            snatchGroup.Name = "红包聊天室";

            List<MeGrabUserDataObject> users = new List<MeGrabUserDataObject>();
            for (int i = 0; i < 3; i++)
            {
                MeGrabUserDataObject user = new MeGrabUserDataObject();
                //user.Id = Guid.NewGuid();
                user.Name = "Test0" + i.ToString();
                users.Add(user);
            }

            snatchGroup.Members = users;
            snatchGroupScenario.Group = snatchGroup;

            return View(snatchGroupScenario);
        }

        public ActionResult SnatchRedPacket(string redPacketActivityId)
        {
            return View("Index");
        }

    }
}
