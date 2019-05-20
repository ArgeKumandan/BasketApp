using BasketApp.Model;
using System.Linq;

namespace BasketApp.Service.Campaign
{
    public class BreadCampaign : ICampaign
    {
        public float CalculateDiscount(BasketModel basketModel)
        {

            var butterCount = basketModel.Items
                .Where(t => t.Product.Name == "Butter")
                .Sum(t => t.Amount);
            if (butterCount < 2 || !basketModel.Items.Any(t => t.Product.Name == "Bread"))
            {
                return 0;
            }
            var bread = basketModel.Items.First(t => t.Product.Name == "Bread");
            var result = (butterCount / 2) * (bread.Product.Price / 2);
            return result;
        }
    }
}
