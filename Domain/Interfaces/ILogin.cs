using Domain.Models;

namespace Domain.Interfaces
{
    public interface ILogin
    {
        bool FindExistsByUserName(Login login);
    }
}
