using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reservas.Models.Map.MapUsuario;

namespace Reservas.Models.Map
{
    public class ReservasDbContext : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }

        public ReservasDbContext(DbContextOptions<ReservasDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
