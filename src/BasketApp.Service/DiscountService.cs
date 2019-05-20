using BasketApp.Model;
using BasketApp.Service.Campaign;
using BasketApp.Service.Contract;
using System.Collections.Generic;
using System.Linq;

namespace BasketApp.Service
{
    public class DiscountService : IDiscountService
    {
        private readonly IEnumerable<ICampaign> _campaigns;
        public DiscountService(IEnumerable<ICampaign> campaigns)
        {
            _campaigns = campaigns;
        }
        public float CalculateDiscount(BasketModel basketModel)
        {
            return _campaigns.Sum(t => t.CalculateDiscount(basketModel));
        }
    }
}
