using Eagle.Domain.Application;
using MeGrab.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace MeGrab.ServiceContracts
{
    [ServiceContract()]
    public interface IAccountService
    {
        [OperationContract()]
        [WebInvoke(UriTemplate = "Account/Register", Method = "Post", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        RegisterResponse Register(RegisterRequest registerRequest);

        [OperationContract()]
        [WebInvoke(UriTemplate = "Account/Login", Method = "Get", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        LoginResponse Login(LoginRequest loginRequest);

        [OperationContract()]
        [WebInvoke(UriTemplate = "Account/Logout", Method = "Get", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        LogoutResponse Logout(LogoutRequest logoutRequest);

        [OperationContract()]
        [WebInvoke(UriTemplate = "Account/ChangePassword", Method = "Post", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ChangePassordResponse ChangePassword(ChangePasswordRequest changePasswordRequest);
    }
}
