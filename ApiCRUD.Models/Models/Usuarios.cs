using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCRUD.Models.Models
{
    public class Usuarios
    {
        public int idUsuario { get; set; }                    // idUsuario (PK)
        public string nombre { get; set; } = "";       // nombre (varchar(50))
        public string apellido { get; set; } = "";     // apellido (varchar(50))
        public string telefono { get; set; } = "";     // telefono (varchar(50))
        public string usuario { get; set; } = "";      // usuario (varchar(50))
        public string contrasenia { get; set; } = "";  // contrasenia (varchar(50))
        public int idDepartamento { get; set; }        // idDepartartamento (FK)

        // Navegación al lado "uno" (un Usuario pertenece a un Departament)
        public virtual Departament departament { get; set; } = null!;

    }
}
