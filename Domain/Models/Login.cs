using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Login 
    {
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        [Key]
        public string UserName { get; private set; }
        public string Password { get; private set; }
    }
}
