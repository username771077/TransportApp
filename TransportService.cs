using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    
    public class TransportService : ITransportService
    {
        

        private readonly AppDbContext _context;
        public TransportService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(TransportFormModel transport)
        {


            // Retrieve the related entities from the database
            var fuelType = _context.FuelTypes.Find(transport.FuelId);
            var transportCategory = _context.TransportCategories.Find(transport.CategoryId);
            var transportBrand = _context.TransportBrands.Find(transport.BrandId);
            transportCategory.TransportType = _context.TransportTypes.Find(transportCategory.TransportTypeId);
            transportBrand.Manufacturer = _context.Manufacturers.Find(transportBrand.ManufacturerId);

            var newTransport = new Transport()
            {
                FuelType = fuelType,
                TransportName = transport.TransportName,
                TransportCategory = transportCategory,
                TransportBrand = transportBrand,                
                

                //transport.TransportCategory = transportCategory;
                //transport.TransportBrand = transportBrand;
                //transport.TransportCategory.TransportType = transportType;
                //tTransportBrand.Manufacturer = transportManufacturer;
            };

            //// Set the navigation properties of the transport entity
            //transport.FuelType = fuelType;
            //transport.TransportCategory = transportCategory;
            //transport.TransportBrand = transportBrand;
            //transport.TransportCategory.TransportType = transportType;
            //transport.TransportBrand.Manufacturer = transportManufacturer;

            _context.Transports.Add(newTransport);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transport> GetAll()
        {
            //var result = _context.Transports.ToList();
            var result = _context.Transports
                .Include(result => result.FuelType)
                .Include(result => result.TransportCategory)
                .Include(result => result.TransportCategory.TransportType)
                .Include(result => result.TransportBrand)
                .Include(result => result.TransportBrand.Manufacturer)
                .ToList();
            return result;
        }

        public Transport GetById(int id)
        {
            var result = _context.Transports.FirstOrDefault(n => n.TransportNumber == id);
            return result;

        }

        public List<TransportCategory> GetCategoryItems()
        {
            var categoryItems = _context.TransportCategories.ToList();
            return categoryItems;
        }

        //public int GetManufacturerTypeByBrand(int brandId)
        //{
        //    var brandCategory = _context.TransportBrands
        //        .Include(tc => tc.Manufacturer)
        //        .FirstOrDefault(tc => tc.BrandId == brandId);

        //    return brandCategory?.Manufacturer?.ManufacturerId ?? 0;
        //}
        public int GetManufacturerTypeByBrand(int brandId)
        {
            var brandCategory = _context.TransportBrands
                .Include(tc => tc.Manufacturer)
                .FirstOrDefault(tc => tc.BrandId == brandId);

            // Check if brandCategory is null before accessing the Manufacturer property
            if (brandCategory != null)
            {
                return brandCategory.Manufacturer?.ManufacturerId ?? 0;
            }

            // Handle the case when brandCategory is null (brandId not found)
            return 0;
        }


        public List<TransportBrand> GetTransportBrands()
        {
            var categoryItems = _context.TransportBrands.ToList();
            return categoryItems;
        }

        public int GetTransportTypeByCategory(int categoryId)
        {
            var transportCategory = _context.TransportCategories
                .Include(tc => tc.TransportType)
                .FirstOrDefault(tc => tc.CategoryId == categoryId);

            return transportCategory?.TransportType?.TypeId ?? 0;
        }

        public Transport Update(int id, Transport newTransport)
        {
            throw new NotImplementedException();
        }
    }
}
