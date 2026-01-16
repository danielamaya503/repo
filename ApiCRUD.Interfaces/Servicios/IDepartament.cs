using ApiCRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCRUD.Interfaces.Servicios
{
    public interface IDepartament
    {
        public Task<IEnumerable<Departament>> GetALLDepartaments();
        //Delete
        public Task<int> DeleteUser(int id);
        //Get by Id
        public Task<Departament> GetUserById(int id);
        //POST
        public Task<Departament> CreateUser(Usuario user);
        //PUT
        public Task<Departament> UpdateUser(Usuario user);

        //path
    }
}
