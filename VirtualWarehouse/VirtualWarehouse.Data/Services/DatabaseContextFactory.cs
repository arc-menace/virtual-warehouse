using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VirtualWarehouse.Data.Services
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        //https://medium.com/oppr/net-core-using-entity-framework-core-in-a-separate-project-e8636f9dc9e5
        //string[] args required by IDesignTimeDbContextFactory function
        public DatabaseContext CreateDbContext(string[] args)
        {
            //Create Options Builder
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            //Provide Database connection string
            builder.UseSqlServer(DatabaseConnection.ConnectionString());
            return new DatabaseContext(builder.Options);
        }
    }
}
