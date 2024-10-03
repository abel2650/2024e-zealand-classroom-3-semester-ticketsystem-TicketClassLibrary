namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a generic vehicle, providing properties for license plate and date,
    /// as well as abstract methods for price calculation and vehicle type description.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Represents the unique identifier for a vehicle's registration plate.
        /// The license plate cannot exceed 7 characters in length.
        /// </summary>
        private string _licenseplate;

        /// <summary>
        /// Gets or sets the license plate number of the vehicle.
        /// The license plate cannot be longer than 7 characters.
        /// </summary>
        /// <exception cref="System.ArgumentException">
        /// Thrown when the length of the provided license plate exceeds 7 characters.
        /// </exception>
        public string Licenseplate
        {
            get { return _licenseplate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                }
                _licenseplate = value;
            }
        }

        /// <summary>
        /// Gets or sets the date related to the vehicle.
        /// </summary>
        /// <remarks>
        /// This property holds the date information, typically representing the time of the relevant event
        /// associated with the vehicle, such as the date of travel or transaction.
        /// </remarks>
        public DateTime Date { get; set; }

        /// <summary>
        /// Calculates the price of the vehicle. If the Brobizz discount is applied, the price is reduced.
        /// </summary>
        /// <param name="useBrobizz">Indicates whether the Brobizz discount should be applied to the price.</param>
        /// <returns>The calculated price of the vehicle, either with or without the Brobizz discount based on the input parameter.</returns>
        public abstract double Price(bool useBrobizz = false); // Opdateret til at inkludere parameter

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>
        /// A string representing the type of the vehicle.
        /// </returns>
        public abstract string VehicleType();

        /// <summary>
        /// Applies the Brobizz discount to the given price.
        /// </summary>
        /// <param name="price">The original price before applying the discount.</param>
        /// <returns>The price after applying the Brobizz discount.</returns>
        public double ApplyBrobizzDiscount(double price)
        {
            return price * 0.95; // 5% rabat
        }
    }
}