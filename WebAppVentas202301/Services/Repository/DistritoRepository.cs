using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Services.Repository
{
    public class DistritoRepository : IDistrito
    {
        private BdVentas bd = new BdVentas();
        public IEnumerable<TbDistrito> GetAllDistritos()
        {
           return bd.TbDistritos.ToList();  
            
        }
    }
}