using ApiCRUD.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCRUD.Datos
{
    public class AppDbContext : DbContext
    {
        //definimos las tablas
        public DbSet<Usuarios> Users => Set<Usuarios>();
        //definimos las tablas
        public DbSet<Departament> depart => Set<Departament>();

        //constructor para pasar las opciones de configuracion
        public AppDbContext(DbContextOptions option): base(option) { 
        
        }

        //configuraciones adicionales de los modelos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuraciones adicionales de los modelos
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departament>(entity => {

                entity.ToTable("Departament");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired();
                entity.Property(e => e.descripcion).IsRequired();

                //definimos la relacion entre Departament y Usuarios
                //muchos a uno
                entity.HasOne(e => e.usuario).WithMany(d => d.departament).HasForeignKey(e => e.usuario);
            });

            modelBuilder.Entity<Usuarios>(entity => {
                entity.ToTable("Usuarios");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.nombre).IsRequired();
                entity.Property(e => e.apellido).IsRequired();
                entity.Property(e => e.telefono).IsRequired();
                entity.Property(e => e.usuario).IsRequired();
                entity.Property(e => e.contrasenia).IsRequired();
            });
        }
    }
}
