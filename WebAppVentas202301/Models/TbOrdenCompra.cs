using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbOrdenCompra
{
    public string NumOco { get; set; } = null!;

    public DateTime FecOco { get; set; }

    public string CodPrv { get; set; } = null!;

    public DateTime FecAte { get; set; }

    public string EstOco { get; set; } = null!;

    public virtual TbProveedor CodPrvNavigation { get; set; } = null!;

    public virtual ICollection<TbDetalleCompra> TbDetalleCompras { get; set; } = new List<TbDetalleCompra>();
}
