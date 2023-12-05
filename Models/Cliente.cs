using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Id do cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteDataNascimento")]
        [Display(Name = "Data de nascimento cliete")]
        public DateTime ClienteDataNascimento { get; set; }

        [Column("ClienteCpf")]
        [Display(Name = "cpf do cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "endereco do cliente")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("ClienteNumeroCasa")]
        [Display(Name = "endereco numero do cliente")]
        public string ClienteNumeroCasa { get; set; } = string.Empty;

        [Column("ClienteBairro")]
        [Display(Name = "endereco beirro numero do cliente")]
        public string ClienteBairro { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "cidade")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [Column("ClienteTelefone")]
        [Display(Name = "telefone do cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;
    }
}
