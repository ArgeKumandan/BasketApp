using BasketApp.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasketApp.Test
{
    [TestClass]
    public class CampaignTester
    {
        private readonly BasketService _basketService;
        public CampaignTester()
        {
            _basketService = Tools.GetBasketService();
        }
        [TestMethod]
        public void FirstScenario()
        {
            var basket = Tools.GetBasket(butterCount: 1, milkCount: 1, breadCount: 1);
            var totalCost = _basketService.CalculateTotalCost(basket);
            Assert.AreEqual(2.95f, totalCost);
        }
        [TestMethod]
        public void SecondScenario()
        {
            var basket = Tools.GetBasket(butterCount: 2, milkCount: 0, breadCount: 2);
            var totalCost = _basketService.CalculateTotalCost(basket);
            Assert.AreEqual(3.10f, totalCost);
        }

        [TestMethod]
        public void ThirdScenario()
        {
            var basket = Tools.GetBasket(butterCount: 0, milkCount: 4, breadCount: 0);
            var totalCost = _basketService.CalculateTotalCost(basket);
            Assert.AreEqual(3.45f, (float)Math.Round(totalCost, 2));
        }


        [TestMethod]
        public void Fourthcenario()
        {
            var basket = Tools.GetBasket(butterCount: 2, breadCount: 1, milkCount: 8);
            var totalCost = _basketService.CalculateTotalCost(basket);
            Assert.AreEqual(9.00f, (float)Math.Round(totalCost, 2));
        }

    }
}