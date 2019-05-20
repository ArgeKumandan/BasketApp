using BasketApp.Model;

namespace BasketApp.Service.Campaign
{
    public interface ICampaign
    {
        float CalculateDiscount(BasketModel basketModel);
    }
}
