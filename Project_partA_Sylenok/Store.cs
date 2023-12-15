using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Sylenok
{
    public class Store : IInventoryManager
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<InventoryItem> Inventory { get; set; } = new List<InventoryItem>();

        public Store(string name, string address)
        {
            throw new NotImplementedException();
        }

        public void AddProductToInventory(ISellable product, int quantity)
        {
            throw new NotImplementedException();
        }

        public void PrintInventory()
        {
            throw new NotImplementedException();
        }

        public void SellProduct(string productName, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
