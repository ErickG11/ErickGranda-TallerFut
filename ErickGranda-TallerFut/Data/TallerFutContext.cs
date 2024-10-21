using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ErickGranda_Taller.Models;

    public class TallerFutContext : DbContext
    {
        public TallerFutContext (DbContextOptions<TallerFutContext> options)
            : base(options)
        {
        }

        public DbSet<ErickGranda_Taller.Models.Equipo> Equipo { get; set; } = default!;

public DbSet<ErickGranda_Taller.Models.Estadio> Estadio { get; set; } = default!;

public DbSet<ErickGranda_Taller.Models.Jugador> Jugador { get; set; } = default!;
    }
