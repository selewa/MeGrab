using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Eagle.Web.Security
{
    [Serializable()]
    public class PassportTokenItem
    {
        public PassportTokenItem(string token, PassportAuthenticationTicket credential, DateTime expire)
        {
            this.Token = token;
            this.Credential = credential;
            this.Expire = expire;
        }

        public string Token 
        { 
            get; 
            private set; 
        }

        public PassportAuthenticationTicket Credential 
        { 
            get; 
            private set; 
        }

        public DateTime Expire 
        { 
            get; 
            set; 
        }
    }
}
