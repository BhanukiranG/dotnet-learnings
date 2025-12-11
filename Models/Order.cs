namespace RestaurantApp.Models
{
    /// <summary>
    /// Represents a customer's order.
    /// Encapsulates the list of menu items and provides billing functionality.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Internal list storing ordered items.
        /// Encapsulation: kept private to protect integrity.
        /// </summary>
        private readonly List<MenuItem> _items = [];

        /// <summary>
        /// Public read-only list of ordered items.
        /// Prevents modification from outside.
        /// </summary>
        public IReadOnlyList<MenuItem> Items => _items;

        /// <summary>
        /// Adds an item to the order.
        /// </summary>
        /// <param name="item">Menu item to add.</param>
        public void AddItem(MenuItem item)
        {
            _items.Add(item);
        }

        /// <summary>
        /// Calculates the total bill amount.
        /// </summary>
        /// <returns>Total price of ordered items.</returns>
        public decimal GetTotal()
        {
            decimal total = 0;

            _items.ForEach(item => total += item.Price);

            return total;
        }

    }
}