using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCRUD.Models.Models
{
    public class Departament
    {
        public int idDepartamento { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;

        // Navegación al lado "muchos" (un Departament tiene muchos Usuarios)
        public virtual ICollection<Usuarios> usuarios { get; set; } = new List<Usuarios>();
    }
}
