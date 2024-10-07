using TicketClassLibrary;

namespace OresundTicketLibrary
{
    /// <summary>
    /// Represents a motorcycle passing through the Oresund bridge.
    /// Applies specific pricing rules, including a discount for Brobizz users.
    /// Inherits from the MC class.
    /// </summary>
    public class OresundMC : MC
    {
        /// <summary>
        /// Calculates the price for crossing the Oresund bridge with an MC.
        /// </summary>
        /// <param name="useBrobizz">Indicates whether a Brobizz discount should be applied.</param>
        /// <returns>The price for crossing, with a discount if Brobizz is used.</returns>
        public override double Price(bool useBrobizz = false)
        {
            // Standard pris
            double price = 210;

            // Brobizz pris for MC
            if (useBrobizz)
            {
                price = 73;
            }

            return price;
        }

        /// <summary>
        /// Gets the type of the vehicle.
        /// </summary>
        /// <returns>A string representing the type of the vehicle, "Oresund MC".</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}