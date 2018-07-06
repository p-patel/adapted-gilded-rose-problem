using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRoseProblem;

namespace TestGildedRoseProblem
{
    [TestClass]
    public class TestHikedTicketItem
    {
        [TestMethod]
        public void TestHikedTicketItem_Age_QualityIncreaseIs1WhenSellInIsMoreThan10()
        {
            //Arrange
            Item item = new HikedTicketItem("test-hiked-ticket-item", 11, 10);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10+1, item.Quality);
        }

        [TestMethod]
        public void TestHikedTicketItem_Age_QualityIncreaseIs2WhenSellInIsBetween10And6()
        {
            //Arrange
            Item item = new HikedTicketItem("test-hiked-ticket-item", 10, 10);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10+2, item.Quality);
        }

        [TestMethod]
        public void TestHikedTicketItem_Age_QualityIncreaseIs3WhenSellInIsBetween5And0()
        {
            //Arrange
            Item item = new HikedTicketItem("test-hiked-ticket-item", 5, 10);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10+3, item.Quality);
        }

        [TestMethod]
        public void TestHikedTicketItem_Age_QualityIncreaseIs3WhenSellInIs0()
        {
            //Arrange
            Item item = new HikedTicketItem("test-hiked-ticket-item", 0, 10);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(10+3, item.Quality);
        }

        [TestMethod]
        public void TestHikedTicketItem_Age_QualityIs0WhenSellInIsLessThan0()
        {
            //Arrange
            Item item = new HikedTicketItem("test-hiked-ticket-item", -1, 10);

            //Act
            item.Age();

            //Assert
            Assert.AreEqual(0, item.Quality);
        }
    }
}
