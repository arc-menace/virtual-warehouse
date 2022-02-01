using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWarehouse.DataAccess
{
    //Used by EF core to find the DbContext for Migrations
    public class VirtualWarehouseDbContextFactory : IDesignTimeDbContextFactory<VirtualWarehouseDbContext>
    {
        public VirtualWarehouseDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VirtualWarehouseDbContext>();
            optionsBuilder.UseSqlServer(VirtualWarehouseDbContext.ConnectionString);

            return new VirtualWarehouseDbContext(optionsBuilder.Options);
        }
    }
}
