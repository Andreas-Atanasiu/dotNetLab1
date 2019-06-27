using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class CarsDbContext : DbContext
    {

        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
