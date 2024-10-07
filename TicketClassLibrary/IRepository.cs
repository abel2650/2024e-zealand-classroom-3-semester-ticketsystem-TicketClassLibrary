using System.Collections.Generic;
using System.Linq;

namespace TicketClassLibrary
{
    // Interface til Repository
    /// <summary>
    /// Interface for defining a repository for ticket management.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Adds a new ticket to the repository.
        /// </summary>
        /// <param name="ticket">The ticket object to add.</param>
        void AddTicket(Ticket ticket);

        /// <summary>
        /// Retrieves all tickets from the repository.
        /// </summary>
        /// <returns>A list of all ticket objects.</returns>
        List<Ticket> GetAllTickets();

        /// <summary>
        /// Retrieves a list of tickets based on the specified license plate.
        /// </summary>
        /// <param name="licensePlate">The license plate number to filter the tickets.</param>
        /// <returns>A list of tickets that match the specified license plate.</returns>
        List<Ticket> GetTicketsByLicensePlate(string licensePlate);
    }

    // Repository klasse der implementerer interface
    /// <summary>
    /// Repository class for managing Ticket objects.
    /// </summary>
    /// This class implements the IRepository interface and provides methods
    /// to add tickets, retrieve all tickets, and get tickets by license plate.
    /// Uses an in-memory list as the data store.
    public class Repository : IRepository
    {
        /// <summary>
        /// A static list used to store Ticket objects within the Repository class.
        /// This list holds all the tickets that are added via the AddTicket method and
        /// retrieved through the GetAllTickets and GetTicketsByLicensePlate methods.
        /// </summary>
        private static List<Ticket> tickets = new List<Ticket>();

        // Metode til at tilføje en ny billet
        /// <summary>
        /// Adds a ticket to the repository.
        /// </summary>
        /// <param name="ticket">The ticket to be added.</param>
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        // Metode til at hente alle billetter
        /// <summary>
        /// Retrieves all tickets from the repository.
        /// </summary>
        /// <returns>A list of all tickets.</returns>
        public List<Ticket> GetAllTickets()
        {
            return tickets;
        }

        // Metode til at hente billetter baseret på nummerplade
        /// Retrieves tickets based on the specified license plate.
        /// <param name="licensePlate">The license plate to filter tickets by.</param>
        /// <return>A list of tickets that match the given license plate.</return>
        public List<Ticket> GetTicketsByLicensePlate(string licensePlate)
        {
            return tickets.Where(t => t.LicensePlate == licensePlate).ToList();
        }
    }
}
