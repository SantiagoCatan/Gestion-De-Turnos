using Gestion_de_turnos.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_turnos.Data
{
    public class SistemaTurnosContext:DbContext
    {
        public SistemaTurnosContext(DbContextOptions<SistemaTurnosContext> options)
         :base(options)
        { }

        //quiero que relacionar las tablas de sql con c#
        public DbSet<Cliente>
            Clientes{ get; set; }
        public DbSet<Profesional>
            Profesional{ get; set; }
        public DbSet<Servicio>
            Servicios{ get; set; }
        public DbSet<Turno>
            Turno{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}
