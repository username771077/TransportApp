using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace TransporortApp.Models
{
    public class Transport
    {
        [Key]
        public int TransportNumber { get; set; }

        [Display(Name ="TransportName")]
        [Required(ErrorMessage ="Name is requireed")]
        public string TransportName { get; set; }

        [NotMapped]
        public List<TransportCategory> CategoryItems { get; set; }

        [NotMapped]
        public List<TransportBrand> BrandItems { get; set; }

        //relationships 
        //Fuel

        // Foreign key
        [Display(Name = "FuelId")]
        public int FuelId { get; set; }
        // Navigation property
        [ForeignKey("FuelId")]
        public FuelType FuelType { get; set; }
       
        //Category
        [Display(Name ="CategotyId")]
        public int CategoryId { get; set; } 
        [ForeignKey("CategoryId")]
        public TransportCategory TransportCategory { get; set; }
        //Brand       
        [Display(Name ="BrandId")]
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public TransportBrand TransportBrand { get; set; }
       


       
    }
}
