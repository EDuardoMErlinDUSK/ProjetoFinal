using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Id do produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "descricao do ´prtoduto do cliente")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
