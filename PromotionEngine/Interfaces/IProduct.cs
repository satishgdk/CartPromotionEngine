using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interfaces
{
    /// <summary>
    /// This interface exposed characterstics of Cart
    /// </summary>
    public interface IProduct
    {
        string SKU { get; set; }
        decimal UnitPrice { get; set; }
         

    }
}
