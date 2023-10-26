using System;
using System.Collections.Generic;

namespace WebAppVentas202301.Models;

public partial class TbDistrito
{
    public string CodDis { get; set; } = null!;

    public string? NomDis { get; set; }

    public virtual ICollection<TbCliente> TbClientes { get; set; } = new List<TbCliente>();

    public virtual ICollection<TbProveedor> TbProveedors { get; set; } = new List<TbProveedor>();

    public virtual ICollection<TbVendedor> TbVendedors { get; set; } = new List<TbVendedor>();
}
