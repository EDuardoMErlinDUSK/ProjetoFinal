using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Id do pais")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "pais do cliente")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
