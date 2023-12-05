using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Id do saida produto")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "nome do usuario")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "email do usuario")]
        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "senha do usuario")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
