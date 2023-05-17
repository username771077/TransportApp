using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly AppDbContext _context;
        public ManufacturerService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Manufacturer manufacturer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manufacturer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Manufacturer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Manufacturer Update(int id, Manufacturer newManufacturer)
        {
            throw new NotImplementedException();
        }
    }
}
