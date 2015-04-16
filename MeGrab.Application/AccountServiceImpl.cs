using Eagle.Domain;
using Eagle.Domain.Application;
using Eagle.Domain.Repositories;
using MeGrab.DataObjects;
using MeGrab.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeGrab.Application
{
    public class AccountServiceImpl : ApplicationService, IAccountService
    {
        public AccountServiceImpl(IRepositoryContext repositoryContext) : base(repositoryContext) { }

        public RegisterResponse Register(RegisterRequest registerRequest)
        {
            throw new NotImplementedException();
        }

        public LoginResponse Login(LoginRequest loginRequest)
        {
            throw new NotImplementedException();
        }

        public LogoutResponse Logout(LogoutRequest logoutRequest)
        {
            throw new NotImplementedException();
        }

        public ChangePassordResponse ChangePassword(ChangePasswordRequest changePasswordRequest)
        {
            throw new NotImplementedException();
        }
    }
}
