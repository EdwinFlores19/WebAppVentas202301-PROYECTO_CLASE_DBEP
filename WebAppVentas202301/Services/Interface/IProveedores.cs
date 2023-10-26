using WebAppVentas202301.Models;

namespace WebAppVentas202301.Services.Interface
{
    public interface IProveedores
    {
        IEnumerable<TbProveedor> GetAllProveedores();
        void Add(TbProveedor proveedor);
        void Update(TbProveedor proveedor);
        void Delete(string id);
        TbProveedor GetProveedor(string id);
        void CantidadDeOrdenes(string id);
    }
}
