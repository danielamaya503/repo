using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCRUD.Models.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public string descripcion { get; set; }

        public Usuarios? usuario { get; set; }
    }
}
