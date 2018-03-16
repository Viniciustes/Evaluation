using Domain.Models;

namespace Service.Interfaces
{
    public interface ILoginService
    {
        bool FindExistsByUserName(Login login);
    }
}
