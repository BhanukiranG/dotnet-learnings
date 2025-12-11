using RestaurantApp.Models;

namespace RestaurantApp.Interfaces
{
    /// <summary>
    /// Defines operations related to menu management and order processing.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Displays the restaurant's menu list.
        /// </summary>
        public void ShowMenu();

        /// <summary>
        /// Retrieves a menu item using its display number.
        /// </summary>
        /// <param name="id">Menu index shown to the user.</param>
        /// <returns>The corresponding <see cref="MenuItem"/> or null if invalid.</returns>
        MenuItem? GetMenuItemById(int id);
    }
}