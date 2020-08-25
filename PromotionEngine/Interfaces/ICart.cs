using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.Entities;

namespace PromotionEngine.Interfaces
{
    /// <summary>
    /// This interface exposed characterstics of Cart
    /// </summary>
    public interface ICart
    {
        decimal Total { get; set; }

        void Checkout();
        void AddProduct(Product product, int quantity);

    }
}
