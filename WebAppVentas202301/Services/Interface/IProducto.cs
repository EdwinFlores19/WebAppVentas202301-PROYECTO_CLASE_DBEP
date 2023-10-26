using WebAppVentas202301.Models;

namespace WebAppVentas202301.Services.Interface
{
    public interface IProducto
    {
        IEnumerable<TbProducto> GetAllProducts();
        TbProducto getProducto(string cod);
    }
}
