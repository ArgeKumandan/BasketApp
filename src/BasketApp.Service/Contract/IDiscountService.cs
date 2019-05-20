using BasketApp.Model;

namespace BasketApp.Service.Contract
{
    public interface IDiscountService
    {
        float CalculateDiscount(BasketModel basketModel);
    }
}