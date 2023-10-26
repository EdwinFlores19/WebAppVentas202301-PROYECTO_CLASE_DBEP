using Microsoft.AspNetCore.Mvc;
using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly IProveedores objProveedor;
        public ProveedorController(IProveedores objProveedor)
        {
            this.objProveedor = objProveedor;
        }

        public IActionResult Index()
        {
            ViewBag.ListaDeProveedores = objProveedor.GetAllProveedores();
            return View();
        }
        public IActionResult Grabar()
        {
            return View();
        }
    }
}
