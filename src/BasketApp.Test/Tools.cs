using BasketApp.Model;
using BasketApp.Service;
using BasketApp.Service.Campaign;
using System;
using System.Collections.Generic;

namespace BasketApp.Test
{
    public static class Tools
    {
        public static BasketService GetBasketService()
        {
            var campaigns = new List<ICampaign>()
            {
                new BreadCampaign(),
                new MilkCampaign()
            };
            var discountService = new DiscountService(campaigns);
            var basketService = new BasketService(discountService);
            return basketService;
        }

        public static BasketModel GetBasket(int butterCount, int milkCount, int breadCount)
        {
            return new BasketModel()
            {
                Items = new BasketItemModel[]
               {
                        new BasketItemModel
                        {
                            Amount=butterCount,
                            Product = new ProductModel
                            {
                                 Id =Guid.NewGuid(),
                                 Name  = "Butter",
                                 Price =0.80f
                            }
                        },
                         new BasketItemModel
                        {
                            Amount=milkCount,
                            Product = new ProductModel
                            {
                                 Id =Guid.NewGuid(),
                                 Name  = "Milk",
                                 Price =1.15f
                            }
                        },
                          new BasketItemModel
                        {
                            Amount=breadCount,
                            Product = new ProductModel
                            {
                                 Id =Guid.NewGuid(),
                                 Name  = "Bread",
                                 Price =1.00f
                            }
                        }
                   }
            };
        }
    }
}
