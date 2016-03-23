using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetShop2.Models
{
    public class Animal
    {
        [Key]
        public Int32 PetID { get; set; }

        public String Name { get; set; }
        
        public String Description { get; set; }

        public DateTime Received { get; set; }

        public Int32 Qty { get; set; }

        public Decimal Price { get; set; }

        public string ImageFile { get; set; }
    }
}