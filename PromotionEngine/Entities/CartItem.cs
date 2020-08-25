using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Entities
{
    /// <summary>
    /// Cart Item is representation of Items in cart which abstracting internal functionality
    /// with multiple items which will supports iterating behavior [Iterator pattern]
    /// </summary>
    public class CartItem
    { 
        public CartItem()
        {
            ProcessedQty = 0;
            ToBeProcessedQty = OrderedQty;
            GrossAmount = 0;
        }

        /// <summary>
        /// Represent the actual Product from db and exposed as Item
        /// </summary>
        public Product Item { get; set; }

        /// <summary>
        /// Ordered quantity from UI 
        /// </summary>
        public int OrderedQty { get; set; }

        /// <summary>
        /// when we have different rules to applied we need to determined which are processed [Mutually Exclusive]
        /// </summary>
        public int ProcessedQty { get; set; }
        
        /// <summary>
        /// these are remaining qty which need to processed or fallback to default calculation without any promotion benfit
        /// </summary>
        public int ToBeProcessedQty { get; set; }

        /// <summary>
        /// Each item price by default product unitprice * qty
        /// </summary>
        public decimal GrossAmount { get; set; }


    }
}
