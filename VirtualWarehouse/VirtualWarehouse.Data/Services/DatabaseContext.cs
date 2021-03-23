using Microsoft.EntityFrameworkCore;
using VirtualWarehouse.Data.Models;
using VirtualWarehouse.Data.Models.Attributes;

namespace VirtualWarehouse.Data.Services
{
    public class DatabaseContext : DbContext
    {
        //Add DbSet<> for each model that needs a table
        public DbSet<Thing> Things { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<ThingAttribute> ThingAttributes { get; set; }
        //Constructor
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Give EF core the SQL server connection string
            optionsBuilder.UseSqlServer(DatabaseConnection.ConnectionString());
        }
    }
}
