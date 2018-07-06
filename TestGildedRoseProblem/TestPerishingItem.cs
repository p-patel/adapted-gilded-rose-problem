using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRoseProblem;

namespace TestGildedRoseProblem
{
    [TestClass]
    public class TestPerishingItem
    {
        [TestMethod]
        public void TestPerishingItem_Age_QualityDecreasesByOneWhenSellByDateHasNotPassed()
        {
            //Arrange
            Item item = new PerishingItem("test-perishing-item", 0, 10, 1);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10-1, item.Quality);
        }

        [TestMethod]
        public void TestPerishingItem_Age_QualityDecreasesTwiceAsFastWhenSellByDateHasPassed()
        {
            //Arrange
            Item item = new PerishingItem("test-perishing-item", -1, 10, 1);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10-2, item.Quality);
        }
    }
}
