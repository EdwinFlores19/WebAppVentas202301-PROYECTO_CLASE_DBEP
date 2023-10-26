using Microsoft.AspNetCore.Mvc;
using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Controllers
{
    public class TemporalVentaController : Controller
    {
        private readonly ITemporalVenta _temporalVenta;
        public TemporalVentaController (ITemporalVenta temporal)
        {
            _temporalVenta = temporal;
        }
        public IActionResult Index(TemporalVenta temporal)
        {
            _temporalVenta.add(temporal);

            return RedirectToAction("Index", "Producto");
        }
        public IActionResult VerCarrito()
        {
            return View(_temporalVenta.GetAllTemporarySale());
        }
    }
}
