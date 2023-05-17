using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public interface ITransportService
    {
        IEnumerable<Transport> GetAll();
        Transport GetById(int id);
        void Add(TransportFormModel transport);
        Transport Update(int id, Transport newTransport);
        void Delete(int id);
        List<TransportCategory> GetCategoryItems();
        List<TransportBrand> GetTransportBrands();
        int GetTransportTypeByCategory(int categoryId);
        int GetManufacturerTypeByBrand(int brandId);
    }
}
