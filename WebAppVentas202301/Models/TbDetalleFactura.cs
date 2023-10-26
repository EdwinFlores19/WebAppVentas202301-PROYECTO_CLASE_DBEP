using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbDetalleFactura
{
    public string NumFac { get; set; } = null!;

    public string CodPro { get; set; } = null!;

    public int CanVen { get; set; }

    public decimal PreVen { get; set; }

    public virtual TbProducto CodProNavigation { get; set; } = null!;

    public virtual TbFactura NumFacNavigation { get; set; } = null!;
}
