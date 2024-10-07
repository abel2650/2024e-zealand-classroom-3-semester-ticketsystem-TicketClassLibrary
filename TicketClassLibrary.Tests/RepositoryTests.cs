using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TicketClassLibrary.Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private IRepository repository;

        [TestInitialize]
        public void Setup()
        {
            repository = new Repository();
        }

        [TestMethod]
        public void GetAllTickets_ShouldReturnAllTickets()
        {
            // Arrange
            var ticket1 = new Ticket { LicensePlate = "ABC123", Price = 240 };
            var ticket2 = new Ticket { LicensePlate = "DEF456", Price = 300 };
            repository.AddTicket(ticket1);
            repository.AddTicket(ticket2);

            // Act
            List<Ticket> result = repository.GetAllTickets();

            // Assert
            Assert.AreEqual(2, result.Count, "Der skal være 2 billetter.");
        }
    }
}