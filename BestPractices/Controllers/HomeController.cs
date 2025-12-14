using Microsoft.AspNetCore.Mvc;
using BestPracticesWorkshop.Services;

namespace BestPracticesWorkshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly AddVehicleService _addVehicleService;

        public HomeController(AddVehicleService addVehicleService)
        {
            _addVehicleService = addVehicleService;
        }

        public IActionResult AddMustang()
        {
            _addVehicleService.Add("Mustang");
            return RedirectToAction("Index");
        }

        public IActionResult AddExplorer()
        {
            _addVehicleService.Add("Explorer");
            return RedirectToAction("Index");
        }

        public IActionResult AddEscape()
        {
            _addVehicleService.Add("Escape");
            return RedirectToAction("Index");
        }
    }
}
