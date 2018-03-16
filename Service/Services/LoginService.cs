using Domain.Interfaces;
using Domain.Models;
using Service.Interfaces;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILogin _login;

        public LoginService(ILogin login)
        {
            _login = login;
        }

        public bool FindExistsByUserName(Login login)
        {
            return _login.FindExistsByUserName(login);
        }
    }
}
