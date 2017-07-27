using System;
using NUnit.Framework;
using Moq;

namespace FactoryMethod.Tests
{
    [TestFixture]
    public class FactoryTest
    {
        private IMonsterFactory factory;

        [SetUp]
        public void Setup()
        {
            factory = new MonsterFactory();
        }
        [Test]
        public void CreatesMethodReturnMonster()
        {
            var monster = factory.CreateMonster();
            Assert.That(monster is IMonster);
        }
        [Test]
        public void IsMonsterHasName()
        {
            var monster = factory.CreateMonster();
            Assert.That(String.IsNullOrEmpty(monster.Name), Is.False);
        }
        [Test]
        public void IsMonsterHasHealthBIggerZero()
        {
            var monster = factory.CreateMonster();
            Assert.That(monster.Health, Is.GreaterThan(0));
        }
        [Test]
        public void NumberDevisibleByElevenCreatesDragons()
        {
            var randomMock = new Mock<IRandom>();
            randomMock.Setup(m => m.GetNext(It.IsAny<int>(), It.IsAny<int>())).Returns(11);
            var random = randomMock.Object;
            var factory = new MonsterFactory(random);
            var monster = factory.CreateMonster();
            Assert.That(monster.Name, Is.EqualTo("Dragon"));
        }
    }
}
