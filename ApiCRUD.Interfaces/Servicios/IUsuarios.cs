using ApiCRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCRUD.Interfaces.Servicios
{
    public interface IUsuarios
    {
        //Get
        public Task<IEnumerable<Usuario>> GetAllUsuarios();
        //Delete
        public Task<int> DeleteUser(int id);
        //Get by Id
        public Task<Usuario> GetUserById(int id);
        //POST
        public Task<Usuario> CreateUser(Usuario user);
        //PUT
        public Task<Usuario> UpdateUser(Usuario user);

        //path
    }
}
