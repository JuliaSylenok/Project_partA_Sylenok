using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Sylenok
{
    public class Supplier
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public Supplier(string name, string contactInfo)
        {
            throw new NotImplementedException();
        }

        public void SupplyProductsToStore(Store store, List<ISellable> products, List<int> quantities)
        {
            throw new NotImplementedException();
        }
    }
}
