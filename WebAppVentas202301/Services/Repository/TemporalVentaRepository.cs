using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Services.Repository
{
    public class TemporalVentaRepository : ITemporalVenta
    {
        private List<TemporalVenta> _temporalVentaList =new List<TemporalVenta>();
        public void add(TemporalVenta temporalVenta)
        {
            _temporalVentaList.Add(temporalVenta);
        }

        public IEnumerable<TemporalVenta> GetAllTemporarySale()
        {
            return _temporalVentaList;
        }
    }
}
