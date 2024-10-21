﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ErickGranda_Taller.Models
{
    public class Equipo
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        public bool AceptaExtranjeros { get; set; }

        [ForeignKey("Estadio")]
        public int IDEstadio { get; set; }
        public Estadio? Estadio { get; set; }
    }
}