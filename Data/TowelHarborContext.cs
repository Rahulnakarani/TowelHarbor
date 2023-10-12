using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TowelHarbor.Models;

namespace TowelHarbor.Data
{
    public class TowelHarborContext : DbContext
    {
        public TowelHarborContext (DbContextOptions<TowelHarborContext> options)
            : base(options)
        {
        }

        public DbSet<TowelHarbor.Models.Towels> Towels { get; set; }
    }
}
