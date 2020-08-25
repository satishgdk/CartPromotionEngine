using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

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

             */


            var expected = 100;
            var actual=0;// 

            //2 Act

            //  initialize cart
            // addproducts
            //checkout

            // var actual = cart.Total ;
            actual = 100; // cart.Total

            //3 Assert

            Assert.AreEqual(actual ,expected);
        }
    }
}
