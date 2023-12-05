using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Id do produto")]
        public int Id { get; set;}

        [Column("ProdutoNome")]
        [Display(Name = "Nome do produto")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("QunatidadeEstoque")]
        [Display(Name = "quantidade do produto")]
        public int QunatidadeEstoque { get; set; }

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "tipo doProduto")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "fornecedor doProduto")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
