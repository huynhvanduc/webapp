using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Supplier
    {
        public long SupplierId { set; get; }
        public string Name { set; get; }
        public string City { set; get; }
        public IEnumerable<Product> Products { set; get; }
    }
}
