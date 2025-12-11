using RestaurantApp.Interfaces;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    /// <summary>
    /// Provides menu operations such as showing menu items and fetching item details.
    /// Implements <see cref="IOrderService"/>.
    /// </summary>
    public class OrderService : IOrderService
    {
        /// <summary>
        /// Internal collection storing all available menu items.
        /// </summary>
        private readonly List<MenuItem> _menuItems = [];

        /// <summary>
        /// Constructor initializes the menu with default items (mock database).
        /// </summary>
        public OrderService()
        {
            _menuItems.AddRange([
                new FoodItem("Paneer Butter Masala", 180, true),
                new FoodItem("Chicken Biryani", 250, false),
                new FoodItem("Veg Fried Rice", 150, true),
                new FoodItem("Mutton Curry", 300, false),
                new DrinkItem("Cold Coffee", 120, true),
                new DrinkItem("Masala Chai", 20, false)
            ]);
        }

        /// <inheritdoc/>
        public void ShowMenu()
        {
            Console.WriteLine("\n--- MENU ---");

            for (int i = 0; i < _menuItems.Count; i++)
                Console.WriteLine($"{i + 1}. {_menuItems[i].GetDescription()}");
        }

        /// <inheritdoc/>
        public MenuItem? GetMenuItemById(int id)
        {
            return (id > 0 && id <= _menuItems.Count)
                ? _menuItems[id - 1]
                : null;
        }
    }
}