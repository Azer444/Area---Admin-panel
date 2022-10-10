using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back_fiorello.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}
