
using Microsoft.AspNetCore.Mvc;
using LabSem2Tarea2.crearFormulario.Models;

namespace LabSem2Tarea2.crearFormulario.Controllers
{
    [Route("[controller]")]
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Producto objProd)
        {
            decimal subT = objProd.calcularSubTotal();
            decimal total = objProd.calcularTotal();
            
            ViewData["Message"] = "Producto : "+objProd.Nombre;

            ViewData["Message2"] = "Subtotal : S/. "+subT+"  --> Total : S/. "+total;

            return View("Index");
        }
    }
}