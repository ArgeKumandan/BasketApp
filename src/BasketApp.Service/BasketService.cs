using BasketApp.Model;
using BasketApp.Service.Contract;
using System.Linq;
namespace BasketApp.Service
{
    public class BasketService : IBasketService
    {
        private readonly IDiscountService _discountService;
        public BasketService(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        public float CalculateTotalCost(BasketModel basketModel)
        {
            var totalCost = basketModel.Items
                .Where(t => t.Amount > 0)
                .Sum(t => t.Amount * t.Product.Price);
            var totalDisc = _discountService.CalculateDiscount(basketModel);
            return totalCost - totalDisc;
        }
    }
}