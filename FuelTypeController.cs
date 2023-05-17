using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransporortApp.Data.Services;

namespace TransporortApp.Controllers
{
    public class FuelTypeController : Controller
    {
        private readonly FuelTypeService _service;
        public FuelTypeController(FuelTypeService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }
    }
}
