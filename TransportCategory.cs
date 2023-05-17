using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransporortApp.Models
{
    public class TransportCategory
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name ="CategoryName")]
        [Required(ErrorMessage ="Category name required")]
        public string CategoryName { get; set; }

        //relations
        public List<Transport> Transport_TransportType { get; set; }
        //Types
        [Display(Name = "TransportTypeId")]
        public int TransportTypeId { get; set; }
        [ForeignKey("TransportTypeId")]
        public TransportType TransportType { get; set; }
    }
}
