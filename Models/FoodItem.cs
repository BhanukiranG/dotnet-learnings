namespace RestaurantApp.Models
{
    /// <summary>
    /// Represents a food item in the restaurant.
    /// Inherits from <see cref="MenuItem"/> and adds veg/non-veg classification.
    /// </summary>
    /// <remarks>
    /// Creates a food menu item.
    /// </remarks>
    /// <param name="name">Name of food.</param>
    /// <param name="price">Price of food.</param>
    /// <param name="isVeg">Whether it is vegetarian.</param>
    public class FoodItem(string name, decimal price, bool isVeg) : MenuItem(name, price)
    {
        /// <summary>
        /// Indicates whether the food item is vegetarian.
        /// </summary>
        public bool IsVeg { get; private set; } = isVeg;

        /// <inheritdoc/>
        public override string GetDescription() {
           return $"{Name} - {(IsVeg ? "Veg" : "Non-Veg")} ${Price}";
        }
    }
}