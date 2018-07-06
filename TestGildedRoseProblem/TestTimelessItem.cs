using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRoseProblem;

namespace TestGildedRoseProblem
{
    [TestClass]
    public class TestTimelessItem
    {
        [TestMethod]
        public void TestTimelessItem_Age_QualityIsUnchangedWhenSellByDateHasNotPassed()
        {
            //Arrange
            Item item = new TimelessItem("test-timeless-item", 0, 10);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10, item.Quality);
        }

        [TestMethod]
        public void TestTimelessItem_Age_QualityIsUnchangedWhenSellByDateHasPassed()
        {
            //Arrange
            Item item = new TimelessItem("test-timeless-item", -1, 10);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10, item.Quality);
        }
    }
}
