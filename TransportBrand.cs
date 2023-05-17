using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransporortApp.Models
{
    public class TransportBrand
    {
        [Key]
        public int BrandId { get; set; }
        [Display(Name ="BrandName")]
        [Required(ErrorMessage ="Brand name required")]
        public string BrandName { get; set; }

        //relationships
        public List<Transport> Transport_TransportBrand { get; set; }

        //manufacturer
        [Display(Name ="CinemaId")]
        public int ManufacturerId { get; set; }
        [ForeignKey("CinemaId")]
        public Manufacturer Manufacturer { get; set; }

    }
}
