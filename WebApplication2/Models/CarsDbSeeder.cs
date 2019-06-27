using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class CarsDbSeeder
    {
        public static void Initialize(CarsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for cars
            if (context.Cars.Any())
            {
                return; //DB has been seeded
            }

            context.Cars.AddRange(
                new Car
                {
                    Brand = "Bmw",
                    Engines = "316d, 318d, 320d",
                    Price = 32000,
                    isElectric = false
                },
                new Car
                {
                    Brand = "Mercedes",
                    Engines = "c200, c220, c250",
                    Price = 33500,
                    isElectric = false
                }
                );
            context.SaveChanges();
        }
    }
}
