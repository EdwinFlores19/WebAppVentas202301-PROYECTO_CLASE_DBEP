using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbProducto
{
    public string CodPro { get; set; } = null!;

    public string DesPro { get; set; } = null!;

    public decimal PrePro { get; set; }

    public int StkAct { get; set; }

    public int StkMin { get; set; }

    public string UniMed { get; set; } = null!;

    public string LinPro { get; set; } = null!;

    public string Importado { get; set; } = null!;

    public virtual ICollection<TbAbastecimiento> TbAbastecimientos { get; set; } = new List<TbAbastecimiento>();

    public virtual ICollection<TbDetalleCompra> TbDetalleCompras { get; set; } = new List<TbDetalleCompra>();

    public virtual ICollection<TbDetalleFactura> TbDetalleFacturas { get; set; } = new List<TbDetalleFactura>();
}
