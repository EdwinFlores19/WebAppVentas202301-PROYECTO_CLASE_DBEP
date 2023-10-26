using WebAppVentas202301.Models;

namespace WebAppVentas202301.Services.Interface
{
    public interface IDistrito
    {
        IEnumerable<TbDistrito> GetAllDistritos();        
    }
}
