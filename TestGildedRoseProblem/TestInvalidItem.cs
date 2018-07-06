using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRoseProblem;

namespace TestGildedRoseProblem
{
    [TestClass]
    public class TestInvalidItem
    {
        [TestMethod]
        public void TestInvalidItem_ToString_ReturnsExpectedOutput()
        {
            //Arrange / Act
            Item item = new InvalidItem("test-item", 1, 2);

            //Assert
            Assert.AreEqual("NO SUCH ITEM", item.ToString());
        }

        [TestMethod]
        public void TestInvalidItem_Age_SellInAndQualityAreNotUpdated()
        {
            //Arrange
            Item item = new InvalidItem("test-item", 1, 2);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(1, item.SellIn);
            Assert.AreEqual(2, item.Quality);
        }
    }
}
