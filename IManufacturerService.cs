using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public interface IManufacturerService
    {
        IEnumerable<Manufacturer> GetAll();
        Manufacturer GetById(int id);
        void Add(Manufacturer manufacturer);
        Manufacturer Update(int id, Manufacturer newManufacturer);
        void Delete(int id);
    }
}
