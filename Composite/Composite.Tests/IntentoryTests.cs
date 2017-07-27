using System;
using NUnit.Framework;

namespace Composite.Tests
{
    [TestFixture]
    public class IntentoryTests
    {
        [Test]
        public void CountPropertyIncludesChildCollectionCounts()
        {
            var inventory = new Inventory();
            var sword = new Inventory { Name = "Swords" };
            var ruby = new Inventory { Name = "Rubies" };
            var emerald = new Inventory { Name = "Emeralds" };

            inventory.AddItem("Weapons", sword);
            inventory.AddItem("Gems/Rubies", ruby);
            inventory.AddItem("Gems/Emeralds", emerald);

            Assert.That(inventory.Count, Is.EqualTo(3));
        }

        [Test]
        public void CountPropertyIncludesChildCollectionCountsAfterRemove()
        {
            var inventory = new Inventory();
            var sword = new Inventory { Name = "Swords" };
            var ruby = new Inventory { Name = "Rubies" };
            var emerald = new Inventory { Name = "Emeralds" };

            inventory.AddItem("Weapons", sword);
            inventory.AddItem("Gems/Rubies", ruby);
            inventory.AddItem("Gems/Emeralds", emerald);

            inventory.RemoveItem("Weapons", sword);

            Assert.That(inventory.Count, Is.EqualTo(2));
        }

    }
}
