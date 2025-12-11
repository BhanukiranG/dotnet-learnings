namespace RestaurantApp.Models
{
    /// <summary>
    /// Represents the base abstract class for any item in the restaurant menu.
    /// Implements the core properties such as Name and Price.
    /// </summary>
    /// <remarks>
    /// Constructor for initializing the menu item.
    /// </remarks>
    /// <param name="name">Item name.</param>
    /// <param name="price">Item price.</param>
    public abstract class MenuItem(string name, decimal price)
    {
        /// <summary>
        /// Name of the menu item (e.g., "Paneer Butter Masala").
        /// </summary>
        public string Name { get; protected set; } = name;

        /// <summary>
        /// Price of the menu item in rupees.
        /// </summary>
        public decimal Price { get; protected set; } = price;

        /// <summary>
        /// Abstract description of a menu item.
        /// Implemented differently by derived classes like FoodItem / DrinkItem.
        /// </summary>
        /// <returns>Formatted string describing the item.</returns>
        public abstract string GetDescription();
    }
}
