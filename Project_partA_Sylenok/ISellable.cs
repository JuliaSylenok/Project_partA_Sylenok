using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Sylenok
{
    public interface ISellable
    {
        string Name { get; }
        decimal Price { get; }
        ProductStatus Status { get; set; }
    }
}
