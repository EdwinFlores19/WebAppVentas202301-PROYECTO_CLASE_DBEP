using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbAbastecimiento
{
    public string CodPrv { get; set; } = null!;

    public string CodPro { get; set; } = null!;

    public decimal PreAba { get; set; }

    public virtual TbProducto CodProNavigation { get; set; } = null!;

    public virtual TbProveedor CodPrvNavigation { get; set; } = null!;
}
