using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransporortApp.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        [Display(Name ="ManufacturerName")]
        [Required(ErrorMessage ="Manufacturer name is required")]
        public string ManufacturerName { get; set; }

        //relationships
        public List<TransportBrand> Manufacturer_Brand { get; set; }
    }
}
