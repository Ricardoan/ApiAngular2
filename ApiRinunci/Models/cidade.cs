using System.ComponentModel.DataAnnotations;
namespace ApiRinunci.Models
{
    public class cidade
    {
        [Key]
        public int cidadeId { get; set; }
        [Required]
        [StringLength(255)]
        public string nomeCidade { get; set; }
    }
}
