using Laboratorio5.Handlers;
using Laboratorio5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio5.Controllers
{
    public class ExpendingMachineController : Controller
    {
        public IActionResult Index()
        {
            ExpendingMachineHandler machineHandler = new ExpendingMachineHandler();
            ExpendingMachineModel machine = new ExpendingMachineModel();
            machine.supply = machineHandler.ObtainCurrentSupply();
            ViewBag.MainTitle = "Lista de Bebidas";
            return View(machine);
        }
    }
}
