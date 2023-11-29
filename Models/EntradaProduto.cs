using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("EntradaProdutoId")]
        [Display(Name = "Id da entrada produto")]
        public int Id { get; set; }

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "tipo doProduto")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [Column("DataEntradaProduto")]
        [Display(Name = "Data de saida")]
        public DateTime DataEntradaProduto { get; set; }

        [Column("QuantidadeEntrada")]
        [Display(Name = "Id da entrada produto")]
        public int QuantidadeEntrada { get; set; }
    }
}
