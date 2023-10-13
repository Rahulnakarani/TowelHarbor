using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowelHarbor.Models
{
    public class TowelMeterialViewModel
    {
        public List<Towels> Towels { get; set; }
        public SelectList Materials { get; set; }
        public string TowelMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
