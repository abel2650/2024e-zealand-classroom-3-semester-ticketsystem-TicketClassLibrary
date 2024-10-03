using TicketClassLibrary;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a Car, derived from the Vehicle class.
    /// </summary>
    /// <remarks>
    /// This class provides implementation for a vehicle of type Car,
    /// including methods to get the price of the car with an optional Brobizz discount,
    /// and to get the type of the vehicle.
    /// </remarks>
    public class Car : Vehicle
{
    // Override Price metoden for at inkludere Brobizz rabat
    /// <summary>
    /// Calculates the price of the car. If the Brobizz discount is applied, the price is reduced.
    /// </summary>
    /// <param name="useBrobizz">Indicates whether the Brobizz discount should be applied to the price.</param>
    /// <returns>The calculated price of the car, either with or without the Brobizz discount based on the input parameter.</returns>
    public override double Price(bool useBrobizz = false)
    {
        double price = 240; // Fast pris på 240 kr
        return useBrobizz ? ApplyBrobizzDiscount(price) : price;
    }

    /// <summary>
    /// Returns the type of the vehicle.
    /// </summary>
    /// <returns>
    /// A string representing the type of the vehicle, which is "Car" in this case.
    /// </returns>
    public override string VehicleType()
    {
        return "Car";
    }
}
}
