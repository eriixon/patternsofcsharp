using Moq;
using NUnit.Framework;
using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTests
{
    [TestFixture]
    public class PizzaShopTests
    {
        IPizzaSrategy pizzaStrategy;
        IPizza pizza;

        [SetUp]
        public void Setup()
        {
            var pizzaMock = new Mock<IPizza>();
            var pizzaStrategyMock = new Mock<IPizzaSrategy>();

            pizzaMock.SetupProperty(p => p.Name);
            pizzaMock.SetupProperty(p => p.Ingredients, new List<string>());

            pizza = pizzaMock.Object;

            pizza.Name = "Test Pizza";
            pizza.Ingredients.Add("tomato sauce");
            pizza.Ingredients.Add("cheese");

            pizzaStrategyMock.Setup(s => s.BuildPizza()).Returns(pizza);

            pizzaStrategy = pizzaStrategyMock.Object;
        }

        [Test]
        public void ReturnsCheesePizzaByDefault()
        {
            var shop = new PizzaShop();
            var pizza = shop.OrderPizza("Dirty Socks");

            Assert.That(pizza.Name, Is.EqualTo("Cheese"));
        }

        [Test]
        public void CanAddMenuItems()
        {
            var shop = new PizzaShop();

            shop.AddMenuItem("Test", pizzaStrategy);

            var pizza = shop.OrderPizza("Test");

            Assert.That(pizza.Name, Is.EqualTo("Test Pizza"));
        }
    }
}