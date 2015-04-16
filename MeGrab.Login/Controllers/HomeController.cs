using Eagle.Core;
using MeGrab.DataObjects;
using MeGrab.Login.Models;
using MeGrab.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeGrab.Login.Controllers
{
    /// <summary>
    /// 用户信息界面
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("UserDetails")]
        public ActionResult Index(string token, string userName)
        {
            using (IMeGrabUserService userService = ServiceLocator.Instance.GetService<IMeGrabUserService>())
            {
                MeGrabUserDataObject meGrabUser = userService.GetRegisteredUserByName(userName);
                LoginUserInfoModel loginUserInfoModel = new LoginUserInfoModel();
                loginUserInfoModel.Token = token;
                loginUserInfoModel.User = meGrabUser;

                return View("Index", loginUserInfoModel);
            }
        }
    }
}
