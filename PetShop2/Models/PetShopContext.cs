
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetShop2.Models
{
    public class PetShopContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}