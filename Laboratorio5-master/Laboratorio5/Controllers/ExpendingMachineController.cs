using Laboratorio5.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio5.Controllers
{
    public class ExpendingMachineController : Controller
    {
        public IActionResult Index()
        {
            ExpendingMachineHandler machineHandler = new ExpendingMachineHandler();
            var paises = machineHandler.ObtainCurrentSupply();
            ViewBag.MainTitle = "Lista de Bebidas";
            return View(paises);
        }
    }
}
