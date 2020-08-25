using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.Interfaces;

namespace PromotionEngine.Entities
{
    /// <summary>
    /// This class is place holder for representing ProductEntity with SKU as Primary Key
    /// </summary>
    public class Product: IProduct
    {
        public string SKU { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
