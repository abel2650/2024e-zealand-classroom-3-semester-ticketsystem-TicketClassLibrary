using TicketClassLibrary;

namespace OresundTicketLibrary
{
    /// <summary>
    /// Represents a car that travels over the Oresund bridge.
    /// </summary>
    public class OresundCar : Car
    {
        /// <summary>
        /// Calculates the price for crossing the Oresund bridge with a car.
        /// </summary>
        /// <param name="useBrobizz">Indicates whether a Brobizz device is used for a discounted price.</param>
        /// <returns>The cost of crossing the Oresund bridge with a car. The standard price is 410 kr, and the Brobizz price is 161 kr.</returns>
        public override double Price(bool useBrobizz = false)
        {
            // Standard pris
            double price = 410;

            // Brobizz pris for bil
            if (useBrobizz)
            {
                price = 161;
            }

            return price;
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle.</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}