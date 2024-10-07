using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundTicketLibrary;

namespace OresundTicketTests
{
    [TestClass]
    public class OresundCarTests
    {
        [TestMethod]
        public void OresundCar_ShouldReturnRegularPrice()
        {
            // Arrange
            var car = new OresundCar();

            // Act
            double price = car.Price(false); // Uden Brobizz

            // Assert
            Assert.AreEqual(410, price, "The regular price for Oresund car should be 410 kr.");
        }

        [TestMethod]
        public void OresundCar_ShouldReturnBrobizzPrice()
        {
            // Arrange
            var car = new OresundCar();

            // Act
            double price = car.Price(true); // Med Brobizz

            // Assert
            Assert.AreEqual(161, price, "The Brobizz price for Oresund car should be 161 kr.");
        }

        [TestMethod]
        public void OresundCar_ShouldReturnVehicleType()
        {
            // Arrange
            var car = new OresundCar();

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Oresund car", vehicleType, "Vehicle type should be 'Oresund car'.");
        }
    }

    [TestClass]
    public class OresundMCTests
    {
        [TestMethod]
        public void OresundMC_ShouldReturnRegularPrice()
        {
            // Arrange
            var mc = new OresundMC();

            // Act
            double price = mc.Price(false); // Uden Brobizz

            // Assert
            Assert.AreEqual(210, price, "The regular price for Oresund MC should be 210 kr.");
        }

        [TestMethod]
        public void OresundMC_ShouldReturnBrobizzPrice()
        {
            // Arrange
            var mc = new OresundMC();

            // Act
            double price = mc.Price(true); // Med Brobizz

            // Assert
            Assert.AreEqual(73, price, "The Brobizz price for Oresund MC should be 73 kr.");
        }

        [TestMethod]
        public void OresundMC_ShouldReturnVehicleType()
        {
            // Arrange
            var mc = new OresundMC();

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", vehicleType, "Vehicle type should be 'Oresund MC'.");
        }
    }
}
