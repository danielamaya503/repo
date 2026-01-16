using System;
using System.Collections.Generic;

namespace ApiCRUD.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;

    public int? IdDepartamento { get; set; }

    public virtual Departament? IdDepartamentoNavigation { get; set; }
}
