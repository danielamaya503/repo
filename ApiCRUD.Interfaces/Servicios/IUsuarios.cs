using System;
using System.Collections.Generic;
using System.Text;
using ApiCRUD.Models.Models;

namespace ApiCRUD.Interfaces.Servicios
{
    public interface IUsuarios
    {
        //Get
        public Task<IEnumerable<Usuarios>> GetAllUsuarios();
        //Delete
        public Task<int> DeleteUser(int id);
        //Get by Id
        public Task<Usuarios> GetUserById(int id);
        //POST
        public Task<Usuarios> CreateUser(Usuarios user);
        //PUT
        public Task<Usuarios> UpdateUser(Usuarios user);

        //path

    }
}
