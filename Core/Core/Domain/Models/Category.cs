using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domain.Models
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public IList<Product> products { get; set; } = new IList<Product>();
    }
}
