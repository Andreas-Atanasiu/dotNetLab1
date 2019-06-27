using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private CarsDbContext context;
        public CarsController(CarsDbContext context)
        {
            this.context = context;
        }

        // GET: api/Cars
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return context.Cars;
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var existing = context.Cars.FirstOrDefault(flower => flower.Id == id);
            if (existing == null)
            {
                return NotFound();
            }

            return Ok(existing);
        }

        // POST: api/Cars
        [HttpPost]
        public void Post([FromBody] Car car)
        {
            //if (!ModelState.IsValid)
            //{

            //}
            context.Cars.Add(car);
            context.SaveChanges();
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Car car)
        {
            var existing = context.Cars.AsNoTracking().FirstOrDefault(f => f.Id == id);
            if (existing == null)
            {
                context.Cars.Add(car);
                context.SaveChanges();
                return Ok(car);
            }
            car.Id = id;
            context.Cars.Update(car);
            context.SaveChanges();
            return Ok(car);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = context.Cars.FirstOrDefault(flower => flower.Id == id);
            if (existing == null)
            {
                return NotFound();
            }
            context.Cars.Remove(existing);
            context.SaveChanges();
            return Ok();
        }
    }
}
