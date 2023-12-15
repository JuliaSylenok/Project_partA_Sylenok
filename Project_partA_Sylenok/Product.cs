using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Sylenok
{
    public class Product : ISellable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductStatus Status { get; set; }

        public Product(string name, decimal price)
        {
            throw new NotImplementedException();
        }
    }
}
