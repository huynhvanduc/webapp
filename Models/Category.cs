using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Category
    {
        public long CategoryId { set; get;}
        public string Name { set; get; }
        public IEnumerable<Product> Products { set; get; }
    }
}
