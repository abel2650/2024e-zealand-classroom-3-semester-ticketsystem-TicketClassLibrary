using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketClassLibrary.Tests

{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Price_ShouldReturn240()
        {
            // Arrange
            var car = new Car();
            
            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(240, result, "Price for car should be 240 kr.");
        }

        [TestMethod]
        public void VehicleType_ShouldReturnCar()
        {
            // Arrange
            var car = new Car();

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result, "VehicleType should return 'Car'.");
        }
    }
}