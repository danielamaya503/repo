using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCRUD.Models.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? telefono { get; set; }
        public string? usuario { get; set; }
        public string? contrasenia { get; set; }

        public int idDepartamento { get; set; }

        public ICollection<Departament> departament = new List<Departament>();

    }
}
