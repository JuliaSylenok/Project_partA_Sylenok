using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Sylenok
{
    public class InventoryItem
    {
        public ISellable Product { get; }
        public int Quantity { get; set; }
        public decimal Price { get; }

        public InventoryItem(ISellable product, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
