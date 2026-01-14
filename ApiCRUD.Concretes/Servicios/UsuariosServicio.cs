using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ApiCRUD.Interfaces.Servicios;
using ApiCRUD.Models.Models;
using ApiCRUD.Concretes.Datos;

namespace ApiCRUD.Concretes.Servicios
{
    public class UsuariosServicio : IUsuarios
    {
        //private readonly AppDbContext _context;
        //AppDbContext es para interactuar con la base de datos
        private readonly AppDbContext _context;
        //DbSet es para interactuar con la tabla Usuarios en la base de datos
        //private readonly DbSet<Usuarios> _dbSet;

        public UsuariosServicio(AppDbContext context)
        {
            //_usuarios = usuarios;
            _context = context;
            //_dbSet = dbSet;
        }

        public async Task<Usuarios> CreateUser(Usuarios user)
        {
            //_context es el contexto de la base de datos
            //contiene la configuracion y conexion a la base de datos

            //es para agregar un nuevo usuario a la base de datos
            await _context.Usuarios.AddAsync(user);
            //es para guardar los cambios en la base de datos
            await _context.SaveChangesAsync();
            //retorna el usuario creado
            return user;
        }

        public Task<int> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuarios>> GetAllUsuarios()
        {
            //_context contiene la configuracion y conexion a la base de datos
            //Users contiene la tabla Usuarios en la base de datos
            // AsNoTracking es para que no haga seguimiento de los cambios en los objetos
            // ToListAsync es para convertir el resultado en una lista de manera asincrona
            return await _context.Usuarios.AsNoTracking().ToListAsync();
        }

        public Task<Usuarios> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios> UpdateUser(Usuarios user)
        {
            throw new NotImplementedException();
        }
    }
}
