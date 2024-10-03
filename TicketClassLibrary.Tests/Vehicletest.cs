using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketClassLibrary.Tests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Licenseplate_ShouldThrowException_WhenExceeds7Characters_ForCar()
        {
            // Arrange
            var car = new Car();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => car.Licenseplate = "12345678", "License plate cannot be longer than 7 characters.");
        }

        [TestMethod]
        public void Licenseplate_ShouldBeValid_When7CharactersOrLess_ForCar()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Licenseplate = "ABC1234";

            // Assert
            Assert.AreEqual("ABC1234", car.Licenseplate);
        }

        [TestMethod]
        public void Licenseplate_ShouldThrowException_WhenExceeds7Characters_ForMC()
        {
            // Arrange
            var mc = new MC();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => mc.Licenseplate = "12345678", "License plate cannot be longer than 7 characters.");
        }

        [TestMethod]
        public void Licenseplate_ShouldBeValid_When7CharactersOrLess_ForMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            mc.Licenseplate = "XYZ5678";

            // Assert
            Assert.AreEqual("XYZ5678", mc.Licenseplate);
        }

        [TestMethod]
        public void car_shouldApplyBrobizzDisocunt_WhenUSEd()
        {
            // Arrange
            var car = new Car();
            
            // Act
            double discountPrice = car.Price(true);
            
            // Assert
            Assert.AreEqual(228, discountPrice, "The price should reflect a 5% Brobizz discount.");
        }
        [TestMethod]
        public void mc_shouldApplyBrobizzDisocunt_WhenUSEd()
        {
            // Arrange
            var mc = new MC();

            // Act
            double discountPrice = mc.Price(true);

            // Assert
            Assert.AreEqual(118.75, discountPrice, "The price should reflect a 5% Brobizz discount.");
        }
    }
}