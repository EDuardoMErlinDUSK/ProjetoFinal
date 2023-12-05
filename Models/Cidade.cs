using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Id da cidade")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "cidade do cliente")]
        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        [Display(Name = "estado")]
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
    }
}
