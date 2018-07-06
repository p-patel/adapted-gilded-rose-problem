using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRoseProblem;

namespace TestGildedRoseProblem
{
    [TestClass]
    public class TestItem
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestItem_Item_NegativeQualityThrowsArgumentOutOfRangeException()
        {
            //Arrange/Act
            Item item = new PerishingItem("test-item", 0, -1, 1);

            //Assert - see test method attribute
        }

        [TestMethod]
        public void TestItem_Item_MemberValueInitialisationsAreCorrect()
        {
            //Arrange/Act
            Item item = new PerishingItem("test-item", 0, 1, 1);

            //Assert
            Assert.AreEqual("test-item", item.Name);
            Assert.AreEqual(0, item.SellIn);
            Assert.AreEqual(1, item.Quality);
        }

        [TestMethod]
        public void TestItem_Age_SellInIsReducedByOne()
        {
            //Arrange
            Item item = new PerishingItem("test-item", 0, 0, 1);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(0-1, item.SellIn);
        }

        [TestMethod]
        public void TestItem_Age_QualityCannotBeNegative()
        {
            //Arrange
            Item item = new PerishingItem("test-item", 0, 0, 1);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(0, item.Quality);
        }

        [TestMethod]
        public void TestItem_Age_QualityMaxIs50()
        {
            //Arrange
            Item item = new PerishingItem("test-item", 0, 51, 1);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(50, item.Quality);
        }

        [TestMethod]
        public void TestItem_ToString_ReturnsExpectedOutput()
        {
            //Arrange / Act
            Item item = new PerishingItem("test-item", 1, 2, 3);

            //Assert
            Assert.AreEqual("test-item 1 2", item.ToString());
        }
    }
}
