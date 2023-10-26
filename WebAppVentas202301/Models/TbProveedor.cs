using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbProveedor
{
    public string CodPrv { get; set; } = null!;

    public string RazSocPrv { get; set; } = null!;

    public string DirPrv { get; set; } = null!;

    public string? TelPrv { get; set; }

    public string CodDis { get; set; } = null!;

    public string RepVen { get; set; } = null!;

    public virtual TbDistrito CodDisNavigation { get; set; } = null!;

    public virtual ICollection<TbAbastecimiento> TbAbastecimientos { get; set; } = new List<TbAbastecimiento>();

    public virtual ICollection<TbOrdenCompra> TbOrdenCompras { get; set; } = new List<TbOrdenCompra>();
}
