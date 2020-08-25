using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Entities
{ 
    /// <summary>
    /// This class representing Simple promotion for entities of same Product
    /// </summary>
    public class GroupPromotion : Promotion
    {

        public decimal OfferedPrice { get; set; }
        public override void ApplyRule(Cart cart)
        {
            // Apply own logic for this family with concrete defination
        }
    }

}
