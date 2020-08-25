using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using PromotionEngine;
using PromotionEngine.Repositories;

namespace PromotionTestLibrary
{
    [TestFixture]
    public class TestPromotions
    {

        [Test]
        public void TestScenario1()
        {
            //1 Arrange
            // setup inputs 

            RuleRepository promotionDB = new RuleRepository();

            var lstActivePromotions = promotionDB.GetActiveRules();
            ProductRepository productContext = new ProductRepository();
            var products = productContext.Products;

            /*
              Setup unitPrices
              Set Active Promotions
              3 of A's for 130
              2 of B's for  45
              C & D for 30

            Scenario

            1 *A 50
            1 * B 30
            1 * C 20 
            Total =100
             */


            decimal expected = 100;
            decimal actual=0;// 

            //2 Act

            //  initialize cart

            Cart cart = new Cart();
            // addproducts

            cart.AddProduct(products.First(p => p.SKU == "A"), 1);
            cart.AddProduct(products.First(p => p.SKU == "B"), 1);
            cart.AddProduct(products.First(p => p.SKU == "C"), 1);

            cart.AddPromotions(lstActivePromotions);

            // setup promotions to cart 
            // need to introduce a way to handle promotions to Cart and robust Product handling mechanism

            //checkout
            cart.Checkout();

               actual = cart.Total ;
             

            //3 Assert

            Assert.AreEqual(actual ,expected);
        }


        [Test]
        public void TestScenario2()
        {
            //1 Arrange
            // setup inputs 

            RuleRepository promotionDB = new RuleRepository();

            var lstActivePromotions = promotionDB.GetActiveRules();
            ProductRepository productContext = new ProductRepository();
            var products = productContext.Products;

            /*
              Setup unitPrices
              Set Active Promotions
              3 of A's for 130
              2 of B's for  45
              C & D for 30

            Scenario

            5 *A 130 + 2*50
            5 * B 45 +45 + 30
            1 * C 20 
            Total = 370

             */


            decimal expected = 370;
            decimal actual = 0;// 

            //2 Act

            //  initialize cart

            Cart cart = new Cart();
            // addproducts

            cart.AddProduct(products.First(p => p.SKU == "A"), 5);
            cart.AddProduct(products.First(p => p.SKU == "B"), 5);
            cart.AddProduct(products.First(p => p.SKU == "C"), 1);

            cart.AddPromotions(lstActivePromotions);

            // setup promotions to cart 
            // need to introduce a way to handle promotions to Cart and robust Product handling mechanism

            //checkout
            cart.Checkout();

            actual = cart.Total;


            //3 Assert

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestScenario3()
        {
            //1 Arrange
            // setup inputs 

            RuleRepository promotionDB = new RuleRepository();

            var lstActivePromotions = promotionDB.GetActiveRules();
            ProductRepository productContext = new ProductRepository();
            var products = productContext.Products;

            /*
              Setup unitPrices
              Set Active Promotions
              3 of A's for 130
              2 of B's for  45
              C & D for 30

            Scenario

            3 *A 130  
            5 * B 45 +45 + 1* 30
            1 * C -
            1 * D 30
            Total = 280

             */


            decimal expected = 280;
            decimal actual = 0;// 

            //2 Act

            //  initialize cart

            Cart cart = new Cart();
            // addproducts

            cart.AddProduct(products.First(p => p.SKU == "A"), 3);
            cart.AddProduct(products.First(p => p.SKU == "B"), 5);
            cart.AddProduct(products.First(p => p.SKU == "C"), 1);
            cart.AddProduct(products.First(p => p.SKU == "D"), 1);
            cart.AddPromotions(lstActivePromotions);

            // setup promotions to cart 
            // need to introduce a way to handle promotions to Cart and robust Product handling mechanism

            //checkout
            cart.Checkout();

            actual = cart.Total;


            //3 Assert

            Assert.AreEqual(actual, expected);
        }
    }
}


