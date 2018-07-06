using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRoseProblem;

namespace TestGildedRoseProblem
{
    [TestClass]
    public class TestItemFactory
    {
        [TestMethod]
        public void TestItemFactory_Get_ReturnsPerishingItemForNameNormalItem()
        {
            //Arrange / Act
            Item item = ItemFactory.Get("Normal Item", 1, 1);

            //Assert
            Assert.AreEqual(typeof(PerishingItem), item.GetType());
        }

        [TestMethod]
        public void TestItemFactory_Get_ReturnsAppreciatingItemForNameAgedBrie()
        {
            //Arrange / Act
            Item item = ItemFactory.Get("Aged Brie", 1, 1);

            //Assert
            Assert.AreEqual(typeof(AppreciatingItem), item.GetType());
        }

        [TestMethod]
        public void TestItemFactory_Get_ReturnsHikedTicketItemForNameBackstagePasses()
        {
            //Arrange / Act
            Item item = ItemFactory.Get("Backstage passes", 1, 1);

            //Assert
            Assert.AreEqual(typeof(HikedTicketItem), item.GetType());
        }

        [TestMethod]
        public void TestItemFactory_Get_ReturnsTimelessItemForNameSulfuras()
        {
            //Arrange / Act
            Item item = ItemFactory.Get("Sulfuras", 1, 1);

            //Assert
            Assert.AreEqual(typeof(TimelessItem), item.GetType());
        }

        [TestMethod]
        public void TestItemFactory_Get_ReturnsInvalidItemForNameInvalidItem()
        {
            //Arrange / Act
            Item item = ItemFactory.Get("Invalid Item", 1, 1);

            //Assert
            Assert.AreEqual(typeof(InvalidItem), item.GetType());
        }
    }
}
