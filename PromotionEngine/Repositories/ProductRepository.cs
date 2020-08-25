using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Repositories
{
    /// <summary>
    /// This class acts as Wrapper to DB, currently mitigating Fake Data.
    /// </summary>
    public class ProductRepository
    {
        private List<Product> _products = new List<Product>();
        
        /// <summary>
        /// Add constructor with providing Context parameter for loading realtime data from Context.
        /// </summary>
        public ProductRepository()
        {
            LoadProducts();
        }

        /// <summary>
        /// this method will load products (Instead of DB adding objects for this context.)
        /// </summary>
        private void LoadProducts()
        {
            _products = new List<Product>()
            {
                new Product () { SKU ="A" , UnitPrice =50 } ,
                new Product () { SKU ="B" , UnitPrice =30 } ,
                new Product () { SKU ="C" , UnitPrice =20 } ,
                new Product () { SKU ="D" , UnitPrice =15 } ,
            };
        }

        /// <summary>
        /// this Property will represent product entities from DB
        /// </summary>
        public List<Product> Products { 
            get { return _products; }
            set { _products = value; } 
        }
         
    }
}
