using Eagle.Web.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace MeGrab.Login.Controllers
{
    public class PassportServiceController : ApiController
    {
        public PassportAuthenticationTicket GetTokenCredential(string token)
        {
            PassportTokenItem tokenItem = PassportTokenManager.Instance.GetPassportTokenItem(token);

            if (tokenItem != null)
            {
                return tokenItem.Credential;
            }

            return null;
        }
    }
}