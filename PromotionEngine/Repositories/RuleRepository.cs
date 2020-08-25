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
                new SimplePromotion () {
                    RuleID =1 , RuleName ="3 Of A's" , Description = "3 Of A's for 130 " , IsActive =true ,
                    Group =   new Criteria () { ProductName ="A" , Qty =3 , OfferedPrice =130}
                },
                new SimplePromotion () {
                    RuleID =2 , RuleName ="2 Of B's" , Description = "2 Of B's for 45 " , IsActive =true  ,
                     Group =   new Criteria () { ProductName ="B" , Qty =2 , OfferedPrice =45}
                },
                 new GroupedPromotion () {
                    RuleID =3 , RuleName =" C & D " , Description = "C & D for 30 " , IsActive =true ,
                     Groups = new List<Criteria>()
                     {
                         new Criteria () { ProductName ="C" , Qty = 1  ,OfferedPrice =30},
                         new Criteria () { ProductName ="D" , Qty = 1 , OfferedPrice =  0 }

                     }
                 }
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
         
        /// <summary>
        /// Defined own methods for repository to filter data from own sources
        /// </summary>
        /// <returns></returns>
        public List<Promotion> GetActiveRules()
        {
            var filteredRules = _promotions.Where(r => r.IsActive == true).ToList();
            return filteredRules;
        }

    }
}
