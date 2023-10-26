using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbDetalleCompra
{
    public string NumOco { get; set; } = null!;

    public string CodPro { get; set; } = null!;

    public int CanPed { get; set; }

    public virtual TbProducto CodProNavigation { get; set; } = null!;

    public virtual TbOrdenCompra NumOcoNavigation { get; set; } = null!;
}
