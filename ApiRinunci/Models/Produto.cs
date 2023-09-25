using System.ComponentModel.DataAnnotations;

namespace ApiRinunci.Models
{
    public class Produto
    {
        [Key]
        public int produtoId { get; set; }
        [Required]
        [StringLength(255)]
        public string nomeProduto { get; set; }
        [Required]
        [StringLength(255)]
        public string descricaoProduto { get; set; }
        [Required]
        public int precoProduto { get; set; }
        [Required]
        public bool ativo { get; set; }
        [Required]
        public DateTime dataCadastro { get; set; }
    }
}

