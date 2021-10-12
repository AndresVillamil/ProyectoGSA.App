using Microsoft.EntityFrameworkCore;
using ProyectoGSA.App.Dominio.Entidades;

namespace ProyectoGSA.App.Persistencia
{
    public class AppContext : DbContext
    {
       public DbSet<Persona> Persona { get; set; }
       public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Docente> Docente { get; set; }

        public DbSet<Acudiente> Acudiente { get; set; }
               
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Server= localhost; Database = Default");
            }
        }
    }    
}