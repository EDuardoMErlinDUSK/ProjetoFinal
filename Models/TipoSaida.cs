using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Id do saida produto")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "descricao do saida produto")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
