using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Id do estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "estado do cliente")]
        public string EstadoNome { get; set; } = string.Empty;

        [ForeignKey("PaisId")]
        [Display(Name = "estado")]
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }
    }
}
