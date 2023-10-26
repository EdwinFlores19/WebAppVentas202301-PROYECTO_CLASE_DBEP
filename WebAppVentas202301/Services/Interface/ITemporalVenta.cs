using WebAppVentas202301.Models;

namespace WebAppVentas202301.Services.Interface
{
    public interface ITemporalVenta
    {
        void add(TemporalVenta temporalVenta);
        IEnumerable<TemporalVenta> GetAllTemporarySale();    
    }
}
