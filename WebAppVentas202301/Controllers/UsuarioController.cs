using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuario _usuario;
        public UsuarioController(IUsuario usuario)
        {
            _usuario= usuario;
        }
        public IActionResult Index()
        {
            return View();
        }
  
        public IActionResult Validar(Usuario usuario)
        {
            var objUsuario = _usuario.getValidarUsuario(usuario);
            if (objUsuario != null)
            {
                HttpContext.Session.SetString("sesionUsuario", JsonConvert.SerializeObject(objUsuario)); //libreria 
                return RedirectToAction("Index","Producto");
            }
            else
            {
                return View("Index");
            }
            
        }
        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Usuario");
        }
    } 
}
