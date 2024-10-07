using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;

namespace StoreBaeltTicketTests
{
    [TestClass]
    public class StorebaeltCarTests
    {
        [TestMethod]
        public void StorebaeltCar_ShouldApplyWeekendDiscount_WhenWeekend()
        {
            // Arrange
            var car = new StorebaeltCar();
            DateTime testDate = new DateTime(2024, 10, 5); // En lørdag
            car.Date = testDate;

            // Act
            double priceWithDiscount = car.Price(false); // Ingen Brobizz

            // Assert
            Assert.AreEqual(240, priceWithDiscount, "The price should reflect a 20% weekend discount from 300 kr.");
        }

        [TestMethod]
        public void StorebaeltCar_ShouldNotApplyWeekendDiscount_WhenWeekday()
        {
            // Arrange
            var car = new StorebaeltCar();
            DateTime testDate = new DateTime(2024, 10, 7); // En mandag
            car.Date = testDate;

            // Act
            double priceWithoutDiscount = car.Price(false); // Ingen Brobizz

            // Assert
            Assert.AreEqual(300, priceWithoutDiscount, "The price without weekend discount should be 300 kr.");
        }
    }
}