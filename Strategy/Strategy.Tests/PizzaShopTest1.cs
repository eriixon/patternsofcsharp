using System;
using NUnit.Framework;
using Moq;

namespace Strategy.Tests
{
    [TestFixture]
    public class PizzaShopTest1
    {
        private PizzaShop testPizzaShop;
        private Mock<IPizzaShop> pizzaMock;
        private IPizzaShop pizzaMockShop;
        [SetUp]
        public void Setup()
        {
            testPizzaShop = new PizzaShop();
            testPizzaShop.AddMenuItem("Pepperoni", new Peperonni());
            testPizzaShop.AddMenuItem("MeatLovers", new MeatLovers());
            testPizzaShop.AddMenuItem("Smorers", new Smorers());
            testPizzaShop.AddMenuItem("FieryHawaiian", new FieryHawaiian());
            testPizzaShop.AddMenuItem("CornDog", new CornDog());
            testPizzaShop.AddMenuItem("Cheese", new Cheese());

            pizzaMock = new Mock<IPizzaShop>();
            pizzaMock.Setup(s => s.OrderPizza("Pepperoni")).Returns(new Peperonni().BuildPizza());
            pizzaMock.Setup(s => s.OrderPizza("MeatLovers")).Returns(new MeatLovers().BuildPizza());
            pizzaMock.Setup(s => s.OrderPizza("Smorers")).Returns(new Smorers().BuildPizza());
            pizzaMock.Setup(s => s.OrderPizza("FieryHawaiian")).Returns(new FieryHawaiian().BuildPizza());
            pizzaMock.Setup(s => s.OrderPizza("CornDog")).Returns(new CornDog().BuildPizza());
            pizzaMock.Setup(s => s.OrderPizza("FieryHawaiian")).Returns(new FieryHawaiian().BuildPizza());
            pizzaMock.Setup(s => s.OrderPizza("Cheese")).Returns(new Cheese().BuildPizza());
            pizzaMockShop = pizzaMock.Object;
        }
        [Test]
        public void IsPizzaPepperoni()
        {
            var actual = testPizzaShop.OrderPizza("Pepperoni");
            Assert.That(actual.Name, Is.EqualTo("Pepperoni"));
        }
        [Test]
        public void InMenu6Items()
        {
            var menuCount = testPizzaShop.MenuCount;
            Assert.That(menuCount, Is.EqualTo(6));
        }
        [Test]
        public void PepperoniContainsRightIngerdients()
        {
            var actual = pizzaMockShop.OrderPizza("Pepperoni");
            Assert.That(actual.Ingredients, Has.Exactly(1).EqualTo("Tomato sauce"));
            Assert.That(actual.Ingredients, Has.Exactly(1).EqualTo("Cheese"));
            Assert.That(actual.Ingredients, Has.Exactly(1).EqualTo("Pepperoni"));
        }
        [Test]
        public void PizzaShopTest()
        {
            Assert.That(testPizzaShop is IPizzaShop);
        }
        [Test]
        public void PizzaShopTestGivesCheesePizzaByDefault()
        {
            var actual = testPizzaShop.OrderPizza("WowPizza");
            Assert.That(actual.Name, Is.EqualTo("Cheese"));
        }
    }
}
