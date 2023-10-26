using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbFactura
{
    public string NumFac { get; set; } = null!;

    public DateTime FecFac { get; set; }

    public string CodCli { get; set; } = null!;

    public DateTime FecCan { get; set; }

    public string EstFac { get; set; } = null!;

    public string CodVen { get; set; } = null!;

    public decimal PorcIgv { get; set; }

    public virtual TbCliente CodCliNavigation { get; set; } = null!;

    public virtual TbVendedor CodVenNavigation { get; set; } = null!;

    public virtual ICollection<TbDetalleFactura> TbDetalleFacturas { get; set; } = new List<TbDetalleFactura>();
}
