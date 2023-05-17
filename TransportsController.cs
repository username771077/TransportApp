using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TransporortApp.Data;
using TransporortApp.Data.Services;
using TransporortApp.Models;

namespace TransporortApp.Controllers
{
    public class TransportsController : Controller
    {
        private readonly ITransportService _service;
        //private readonly AppDbContext _context;
        public TransportsController(ITransportService service)
        {
            _service = service;
            //_context = context;
        }
        public IActionResult Index()
        {
            
           // var data = _context.Transports.ToList();
            var data = _service.GetAll();            
            return View(data);
        }
        [HttpPost]
        public IActionResult Create(TransportFormModel transport)
        {
            if (!ModelState.IsValid)
            {
               // _service.Add(transport);
                //return RedirectToAction("Index");
                return View(transport);
            }
            _service.Add(transport);
            return RedirectToAction(nameof(Index));

            
        }
        public IActionResult Create()
        {

            // Retrieve the list of category items from the service
            var categoryItems = _service.GetCategoryItems();
            var brandItems = _service.GetTransportBrands();
            //var brandItems=_service.ge

            // Create a new Transport object and assign the category items to it
            var transportView = new TransportCreateViewModel()
            {
                Categories = categoryItems,
                BrandCategories=brandItems,
                Transport = new TransportFormModel()
            };
            //var transport = new Transport();
            //transport.CategoryItems = categoryItems;

            return View(transportView);


        }
        public IActionResult GetTransportTypeByCategory(int categoryId)
        {
            var transportType = _service.GetTransportTypeByCategory(categoryId);
            return Json(transportType);
        }
        public IActionResult GetManufacturerTypeByBrand(int brandId)
        {
           
            var manufacturer = _service.GetManufacturerTypeByBrand(brandId);
            return Json(manufacturer);
        }



    }
}
