using BasketApp.Model;
using System;
using System.Linq;
namespace BasketApp.Service.Campaign
{
    public class MilkCampaign : ICampaign
    {
        public float CalculateDiscount(BasketModel basketModel)
        {
            var milkCount = basketModel.Items
                .Where(t => t.Product.Name == "Milk")
                .Sum(t => t.Amount);
            if (milkCount <= 3)
            {
                return 0;
            }
            var milkProduct = basketModel.Items.First(t => t.Product.Name == "Milk").Product;//to find milk price
            return (milkCount / 3) * milkProduct.Price;
        }
    }
}
