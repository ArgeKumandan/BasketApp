using BasketApp.Model;

namespace BasketApp.Service.Contract
{
    public interface IBasketService
    {
        float CalculateTotalCost(BasketModel basketModel);
    }
}
