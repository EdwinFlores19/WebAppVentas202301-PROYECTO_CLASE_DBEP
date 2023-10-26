using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class VListarCliente
{
    public string Codigo { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Contacto { get; set; } = null!;
}
