using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporortApp.Models
{
    public class TransportCreateViewModel
    {
        public TransportFormModel Transport { get; set; }
        public List<TransportCategory> Categories { get; set; }
        public List<TransportBrand> BrandCategories { get; set; }

    }

    public class TransportFormModel
    {
        public string TransportName { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TypeId { get; set; }
        public int ManufacturerId { get; set; }
    }
}
