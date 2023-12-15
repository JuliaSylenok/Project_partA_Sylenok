using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Sylenok
{
    public interface IInventoryManager
    {
        void AddProductToInventory(ISellable product, int quantity);
        void PrintInventory();
    }
}
