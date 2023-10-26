using Microsoft.AspNetCore.Mvc;
using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;
using WebAppVentas202301.Services.Repository;

namespace WebAppVentas202301.Controllers
{
    public class ClienteController : Controller
    {
        //private ClienteRepository obj = new ClienteRepository();
        private readonly ICliente obj;
        private readonly IDistrito objDistrito;
        public ClienteController(ICliente clienteObj,
                                 IDistrito objDistrito)
        {
            obj = clienteObj;
            this.objDistrito = objDistrito;
        }
        public IActionResult Index()
        {
            ViewBag.ListaDeDistritos = objDistrito.GetAllDistritos();
            return View();
        }
        [Route("cli/listar")]
        [Route("clientes/listar")]
        public IActionResult Listar()
        {
            return View(obj.GetAllClientes());
        }
        public IActionResult Grabar(TbCliente cliente)
        {
            obj.Add(cliente);
            return RedirectToAction("Listar");
        }
        [Route("Cliente/Edit/{cod}")]
        public IActionResult Edit(string cod)
        {
            return View(obj.GetCliente(cod));
        }
        [Route("Cliente/Delete/{cod}")]
        public IActionResult Delete(string cod)
        {
            obj.Delete(cod);
            return RedirectToAction("Listar");
        }

       public IActionResult EditDetails(TbCliente tbCliente)
       {
            obj.Update(tbCliente);
            return RedirectToAction("Listar");
       }
    }
}