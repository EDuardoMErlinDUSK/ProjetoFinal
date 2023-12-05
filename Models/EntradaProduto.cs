using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("Id")]
        [Display(Name = "Id da entrada produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "tipo doProduto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataEntradaProduto")]
        [Display(Name = "Data de saida")]
        public DateTime DataEntradaProduto { get; set; }

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade da entrada de produto")]
        public int QuantidadeEntrada { get; set; }
    }
}
