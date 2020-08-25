using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine;
using PromotionEngine.Repositories;

namespace FlexiCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demoing Cart without Promotions");
            TestCartWithoutPromotions();

            Console.ReadKey();
        }

        /// <summary>
        /// Test method to check library working fine and no impact with promotions
        /// </summary>
        public static void TestCartWithoutPromotions()
        { 
            ProductRepository productContext = new ProductRepository();
            var products = productContext.Products;

            /*
             
            Scenario

            3 *A   150  
            5 * B 150
            2 * C  40
            Total = 340

             */ 

            Cart cart = new Cart(); 

            cart.AddProduct(products.First(p => p.SKU == "A"), 3);
            cart.AddProduct(products.First(p => p.SKU == "B"), 5);
            cart.AddProduct(products.First(p => p.SKU == "C"), 2);
             
            cart.Checkout(); 

        }
    }
}
