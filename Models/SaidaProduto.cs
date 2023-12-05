using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("(Id")]
        [Display(Name = "Id do saida produto")]
        public int Id { get; set;}

        [ForeignKey("ProdutoId")]
        [Display(Name = "produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataSaidaProduto")]
        [Display(Name = "Data de saida")]
        public DateTime DataSaidaProduto { get; set; }

        [Column("(QuantidadeSaida")]
        [Display(Name = "Quantidade da saida do produto")]
        public int QuantidadeSaida { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("TipoSaidaId")]
        [Display(Name = "usuario")]
        public int TipoSaidaId { get; set; }
        public TipoSaida? TipoSaida { get; set; }
    }
}
