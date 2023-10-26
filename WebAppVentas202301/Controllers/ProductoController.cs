using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProducto objProducto;
        public ProductoController(IProducto objProducto)
        {
            this.objProducto = objProducto;
        }

        public IActionResult Index()
        {
            //Obtener el valor de la variable de sesión 
            var objSesion = HttpContext.Session.GetString("sesionUsuario");
            if (objSesion != null)
            {
                //Deserializar el obj con los datos de la sesión 
                var ObjJeje = JsonConvert.DeserializeObject<Usuario>
                    (HttpContext.Session.GetString("sesionUsuario")); //el objeto de usuario
                return View(objProducto.GetAllProducts());
            }
            else
            {
                return RedirectToAction("Index", "Usuario");
            }
           
        }
        [Route("Producto/Comprar/{cod}")]
        public IActionResult Comprar(string cod)
        {
            ViewData["codigo"] = objProducto.getProducto(cod).CodPro;
            ViewData["descripcion"] = objProducto.getProducto(cod).DesPro;
            ViewData["precio"] = objProducto.getProducto(cod).PrePro;
            ViewData["stock"] = objProducto.getProducto(cod).StkAct;


            return View();
        }
    }
}
