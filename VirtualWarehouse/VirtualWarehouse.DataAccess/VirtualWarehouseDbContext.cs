using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;

namespace VirtualWarehouse.DataAccess
{
    public sealed class VirtualWarehouseDbContext : DbContext
    {
        public VirtualWarehouseDbContext(DbContextOptions<VirtualWarehouseDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public static readonly string ConnectionString = "Server=localhost;Database=VirtualWarehouse;Trusted_Connection=True;";

        public DbSet<Asset> Assets { get; set; }
        public DbSet<ImageAttribute> ImageAttributes { get; set; }  
        public DbSet<SavedImage> SavedImages { get; set; }
        public DbSet<TextAttribute> TextAttributes { get; set; }
        public DbSet<HistoryAttribute> HistoryAttributes { get; set; }
        public DbSet<HistoryAttributeItem> HistoryAttributeItems { get; set; }
    }
}
