using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TowelHarbor.Models
{
    public class Towels
    {
        /*Added validation for all the fields*/
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Type{ get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material{ get; set; }

        [Range(1, 1000)]
        [Required]
        public int Stock { get; set; }

        [Range(1, 100)]
        /*Added validation for price*/
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }

        /*Added a new field*/
        [Range(1, 5)]
        [Required]
        public int Rating { get; set; }

        [StringLength(500, MinimumLength = 3)]
        [Required]
        public string Description { get; set; }
    }
}
