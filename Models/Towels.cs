using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TowelHarbor.Models
{
    public class Towels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type{ get; set; }
        public string Material{ get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
