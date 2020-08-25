using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Repositories
{
    /// <summary>
    /// This class acts as Wrapper to rule entities, currently mitigating Fake Data.
    /// </summary>
    public class RuleRepository
    {
        private List<Promotion> _promotions = new List<Promotion>();

        /// <summary>
        /// Add constructor with providing Context parameter for loading realtime data from Context.
        /// </summary>
        public RuleRepository()
        {
            LoadPromotions();
        }

        /// <summary>
        /// this method will load promotions (Instead of DB adding objects for this context.)
        /// </summary>
        private void LoadPromotions()
        {
            _promotions = new List<Promotion>()
            {
                new SimplePromotion () { RuleID =1 , RuleName = "3As for 130" , Description ="3 Combo offer" , IsActive =true}
            };
        }

        /// <summary>
        /// this Property will represent promotion rules  entities from DB
        /// </summary>
        public List<Promotion> Promotions
        {
            get { return _promotions; }
            set { _promotions = value; }
        }



    }
}
