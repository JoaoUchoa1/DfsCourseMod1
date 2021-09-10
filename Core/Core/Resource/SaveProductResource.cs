using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Resource
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int QuantityInPackage { get; set; }
        [Required]
        [MaxLength(3)]
        public string UnitOfMeasurement { get; set; }
        [Required]
        public int CategoryId { get; set; }

    }
}
