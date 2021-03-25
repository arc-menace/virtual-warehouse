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
                var notes = new Text();
                notes.AttributeName = "Notes";
                notes.TextContent = "This is an example note";
                thing.Attributes.Add(notes);

                var description = new Text();
                description.AttributeName = "Description";
                description.TextContent = "This item has a description";
                thing.Attributes.Add(description);

                context.Things.Add(thing);
                context.SaveChanges();
            }
        }
    }
}
