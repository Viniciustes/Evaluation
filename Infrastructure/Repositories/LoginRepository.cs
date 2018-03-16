using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class LoginRepository : Repository, ILogin
    {
        public LoginRepository(ContextDb contextDb)
        {
            _db = contextDb;
        }

        public bool FindExistsByUserName(Login login)
        {
            var codigo = new SqlParameter("@CODIGO", login.UserName);

            return _db.AuthUser
                .FromSql("EXECUTE [dbo].[SPU_GETBYCODIGO] @CODIGO", codigo)
                .ToList().Count > 0;
        }
    }
}
