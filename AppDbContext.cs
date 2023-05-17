using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<TransportType> TransportTypes { get; set; }
        public DbSet<TransportBrand> TransportBrands { get; set; }
        public DbSet<TransportCategory> TransportCategories { get; set; }
    }
}
