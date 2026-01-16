using System;
using System.Collections.Generic;

namespace ApiCRUD.Models;

public partial class Departament
{
    public int IdDepartamento { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
