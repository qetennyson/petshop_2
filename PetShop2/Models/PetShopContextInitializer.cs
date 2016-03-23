using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetShop2.Models
{
    public class PetShopContextInitializer : DropCreateDatabaseIfModelChanges<PetShopContext>
    {
        protected override void Seed(PetShopContext context)
        {
            context.Animals.Add(
                new Animal()
                {
                    Name = "German Shepherd",
                    Description = "Working dog known for its intellignce and magical powers."
                });
        }
    }
}