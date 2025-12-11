namespace RestaurantApp.Models
{
    /// <summary>
    /// Represents a drink item in the restaurant.
    /// Inherits from <see cref="MenuItem"/> and adds hot/cold classification.
    /// </summary>
    /// <remarks>
    /// Creates a drink menu item.
    /// </remarks>
    /// <param name="name">Drink name.</param>
    /// <param name="price">Drink price.</param>
    /// <param name="isCold">Whether it is cold.</param>
    public class DrinkItem(string name, decimal price, bool isCold) : MenuItem(name, price)
    {
        /// <summary>
        /// Indicates whether the drink is cold.
        /// </summary>
        public bool IsCold { get; private set; } = isCold;

        /// <inheritdoc/>
        public override string GetDescription() {
            return $"{Name} - {(IsCold ? "Cold" : "Hot")} ${Price}";
        }
    }
}