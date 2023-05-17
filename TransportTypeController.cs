using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransporortApp.Data.Services;

namespace TransporortApp.Controllers
{
    public class TransportTypeController : Controller
    {
        private readonly ITransportType _service;
        public TransportTypeController(ITransportType service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View();
        }
    }
}
