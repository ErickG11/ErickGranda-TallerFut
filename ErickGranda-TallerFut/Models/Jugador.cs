using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ErickGranda_Taller.Models
{
    public class Jugador
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        public string Posición { get; set; }
        public string Edad { get; set; }
        public Equipo? Equipo { get; set; }

        [ForeignKey("Equipo")]
        public int IDEquipo { get; set; }
        
    }
}
