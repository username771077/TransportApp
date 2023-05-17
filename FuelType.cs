using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransporortApp.Models
{
    public class FuelType
    {
        [Key]
        public int FuelId { get; set; }
        [Display(Name ="Fuel_Type")]
        public string FuelTypeName { get; set; }
        //relationships
        public List<Transport> Transports { get; set;}
    }
}
