using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerQueenC.Models
{
    public class products
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Flavor { get; set; }
        public string Complement { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
    }
}
