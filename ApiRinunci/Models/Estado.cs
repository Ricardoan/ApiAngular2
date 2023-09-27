using System.ComponentModel.DataAnnotations;
namespace ApiRinunci.Models
{
    public class Estado
    {
        [Key]
        public int estadoId { get; set; }
        [Required]
        [StringLength(255)]
        public string nomeEstado { get; set; }

        public string Codigo{ get; set; }
    }
}
