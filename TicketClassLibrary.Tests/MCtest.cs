using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TicketClassLibrary.Tests
{
    [TestClass]
    public class McTests
    {
        [TestMethod]
        public void Price_ShouldReturn125_ForMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(125, result, "Price for MC should be 125 kr.");
        }

        [TestMethod]
        public void VehicleType_ShouldReturnMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            string result = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", result, "VehicleType should return 'MC'.");
        }
    }
}