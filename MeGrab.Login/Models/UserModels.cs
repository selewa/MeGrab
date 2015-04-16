using MeGrab.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeGrab.Login.Models
{
    public class LoginUserInfoModel
    {
        public string Token { get; set; }

        public MeGrabUserDataObject User { get; set; }
    }
}