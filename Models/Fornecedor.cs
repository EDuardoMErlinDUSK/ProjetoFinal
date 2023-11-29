using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("FornecedorId")]
        [Display(Name = "Id do fornecedor")]
        public int Id { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome do fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;

        [Column("FornecedorEmail")]
        [Display(Name = "Email do fornecedor")]
        public string FornecedorEmail { get; set; } = string.Empty;

        [Column("FornecedorCnp")]
        [Display(Name = "Cnp do fornecedor")]
        public string FornecedorCnp { get; set; } = string.Empty;
    }
}
