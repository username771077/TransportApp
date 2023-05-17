using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public class FuelTypeService : IFuelService
    {
        private readonly AppDbContext _context;
        public FuelTypeService(AppDbContext context)
        {
            _context = context; 
        }
        public void Add(FuelType fuel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FuelType> GetAll()
        {
            throw new NotImplementedException();
        }

        public FuelType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public FuelType Update(int id, FuelType newfuelType)
        {
            throw new NotImplementedException();
        }
    }
}
