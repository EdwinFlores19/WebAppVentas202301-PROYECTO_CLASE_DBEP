using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Services.Repository
{
    public class ProductoRepository : IProducto
    {
        private BdVentas bd = new BdVentas();   
        public IEnumerable<TbProducto> GetAllProducts()
        {
            return bd.TbProductos;
        }

        public TbProducto getProducto(string cod)
        {
            var obj = (from tproducto in bd.TbProductos
                       where tproducto.CodPro == cod
                       select tproducto).Single();
            return obj;
        }
    }
}
