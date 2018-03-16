using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class AuthUser
    {
        [Key]
        public string CodUsuario { get; set; }
        public string CodUsuarioRede { get; set; }
        public int CodPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string Chapa { get; set; }
        //public int ContextoAno { get; set; }
        public string Codperfil { get; set; }
    }
}
