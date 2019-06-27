using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Car
    {
        //[Key()]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Engines { get; set; }
        [Range(0, 120000)]
        public int Price { get; set; }
        public bool isElectric { get; set; }
    }
}
