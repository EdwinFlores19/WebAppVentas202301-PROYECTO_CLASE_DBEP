using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string UsuUsuario { get; set; } = null!;

    public string UsuClave { get; set; } = null!;

    public string UsuTipo { get; set; } = null!;
}
