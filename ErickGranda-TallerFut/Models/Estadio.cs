using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace ErickGranda_Taller.Models
{
    public class Estadio
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
    }
}