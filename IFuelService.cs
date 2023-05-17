using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public interface IFuelService
    {
        IEnumerable<FuelType> GetAll();
        FuelType GetById(int id);
        void Add(FuelType fuel);
        FuelType Update(int id, FuelType newfuelType);
        void Delete(int id);
    }
}
