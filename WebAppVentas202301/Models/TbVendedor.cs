using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbVendedor
{
    public string CodVen { get; set; } = null!;

    public string NomVen { get; set; } = null!;

    public string ApeVen { get; set; } = null!;

    public decimal SueldoVen { get; set; }

    public DateTime FecIng { get; set; }

    public string TipVen { get; set; } = null!;

    public string CodDis { get; set; } = null!;

    public virtual TbDistrito CodDisNavigation { get; set; } = null!;

    public virtual ICollection<TbFactura> TbFacturas { get; set; } = new List<TbFactura>();
}
