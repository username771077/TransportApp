using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransporortApp.Models
{
    public class TransportType
    {
        [Key]
        public int TypeId { get; set; }
        [Display(Name ="Transport_Type")]
        [Required(ErrorMessage ="Transport type name is required")]
        public string TransportTypeName { get; set; }

        //relationships
       // public List<Transport> Transport_TransportType { get; set;}
        public List<TransportCategory> categories  { get; set; }
       


    }
}
