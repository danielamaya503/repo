using ApiCRUD.Concretes.Datos;
using ApiCRUD.Interfaces.Servicios;
using ApiCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCRUD.Concretes.Servicios
{
    public class DepartamentosServicio : IDepartament
    {
        //es para interactuar con la base de datos
        private readonly AppDbContext _context;

        //es el constructor de la clase AppDbContext para inicializar el contexto de la base de datos
        public DepartamentosServicio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Departament> CreateUser(Usuario user)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Departament>> GetALLDepartaments()
        {
            //obtenemos todos los departamentos de la base de datos
            var departamentos = await _context.Departaments.ToListAsync();
            //retornamos la lista de departamentos
            return departamentos;
        }
        

        public async Task<Departament> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Departament> UpdateUser(Usuario user)
        {
            throw new NotImplementedException();
        }
    }
}
