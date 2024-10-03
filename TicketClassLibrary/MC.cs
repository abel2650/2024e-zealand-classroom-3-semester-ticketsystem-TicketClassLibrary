namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a motorcycle and extends the Vehicle abstract class.
    /// Provides functionality to calculate the price of crossing for motorcycles, with an optional Brobizz discount.
    /// </summary>
    public class MC : Vehicle
    {
        // Override Price metoden for at inkludere Brobizz rabat
        /// <summary>
        /// Calculates the price of the motorcycle (MC). If the Brobizz discount is applied, the price is reduced.
        /// </summary>
        /// <param name="useBrobizz">Indicates whether the Brobizz discount should be applied to the price.</param>
        /// <returns>The calculated price of the motorcycle, either with or without the Brobizz discount based on the input parameter.</returns>
        public override double Price(bool useBrobizz = false)
        {
            double price = 125; // Fast pris på 125 kr
            return useBrobizz ? ApplyBrobizzDiscount(price) : price;
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>
        /// A string representing the type of the vehicle, which is "MC" in this case.
        /// </returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}