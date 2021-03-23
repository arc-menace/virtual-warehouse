using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Data.Models;
using VirtualWarehouse.Data.Models.Attributes;
using VirtualWarehouse.Data.Services;

namespace VirtualWarehouse.Web
{
    public class SeedDatabase
    {
        public static void Initialize()
        {
            var context = new DatabaseContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext>());

            if (!context.Things.Any())
            {
                var thing = new Thing()
                {
                    ThingName = "Thing"                    
                };
                thing.Attributes.Add(new Note());
                thing.Attributes.Add(new Description());

                context.Things.Add(thing);
                context.SaveChanges();
            }
        }
    }
}
