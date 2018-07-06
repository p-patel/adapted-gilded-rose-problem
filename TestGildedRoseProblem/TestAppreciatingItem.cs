using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRoseProblem;

namespace TestGildedRoseProblem
{
    [TestClass]
    public class TestAppreciatingItem
    {
        [TestMethod]
        public void TestAppreciatingItem_Age_QualityAlwaysIncreasesByOne()
        {
            //Arrange
            Item item = new AppreciatingItem("test-appreciating-item", -1, 10);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10+1, item.Quality);
        }
    }
}
