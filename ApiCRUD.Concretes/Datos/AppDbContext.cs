using ApiCRUD.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCRUD.Concretes.Datos
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Departament> Departaments { get; set; }

        //constructor para pasar las opciones de configuracion
        public AppDbContext(DbContextOptions option): base(option) { 
        
        }

        //configuraciones adicionales de los modelos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapeo EXACTO a tablas de tu BD (dbo schema)
            modelBuilder.Entity<Usuarios>().HasIndex(c => c.idUsuario).IsUnique();

            modelBuilder.Entity<Departament>().HasIndex(c => c.idDepartamento).IsUnique();
        }
    }
}


