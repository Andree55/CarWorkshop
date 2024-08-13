using CarWorkshop.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.Application.Services;

namespace CarWorkshop.MVC.Controllers
{
    public class CarWorkshopController:Controller
    {
        private readonly ICarWorkshopService _carWorkshopService;

        public CarWorkshopController(ICarWorkshopService carWorkshopService)
        {
            _carWorkshopService = carWorkshopService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Domain.Entities.CarWorkshop carWorkshop)
        {
            await _carWorkshopService.Create(carWorkshop);
            return RedirectToAction(nameof(Create)); // TODO: Refactor
        }
    }
}
