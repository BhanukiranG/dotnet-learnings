using RestaurantApp.Models;
using RestaurantApp.Services;
using RestaurantApp.Utils;

namespace RestaurantApp
{
    /// <summary>
    /// Entry point for the Restaurant App.
    /// Handles the UI and coordinates between user actions and service logic.
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            OrderService orderService = new();
            Order order = new();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- RESTAURANT APP ---");
                Console.WriteLine("1. View Menu");
                Console.WriteLine("2. Add Item to Order");
                Console.WriteLine("3. View Bill");
                Console.WriteLine("4. Exit");

                int choice = InputHelper.GetInt("Choose an option: ");

                switch (choice)
                {
                    case 1:
                        orderService.ShowMenu();
                        break;

                    case 2:
                        orderService.ShowMenu();
                        int id = InputHelper.GetInt("Enter item number: ");
                        var item = orderService.GetMenuItemById(id);

                        if (item != null)
                        {
                            order.AddItem(item);
                            Console.WriteLine($"{item.Name} added!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid item!");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n--- BILL ---");

                        foreach (var i in order.Items)
                            Console.WriteLine($"{i.Name}  ${i.Price}");

                        Console.WriteLine($"TOTAL: ₹{order.GetTotal()}");
                        break;

                    case 4:
                        running = false;
                        Console.WriteLine("Thank you! Visit again.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}


// RestaurantApp
// │
// ├── Program.cs
// ├── Models/
// │   ├── MenuItem.cs
// │   ├── FoodItem.cs
// │   ├── DrinkItem.cs
// │   ├── Order.cs
// │
// ├── Interfaces/
// │   └── IOrderService.cs
// │
// ├── Services/
// │   └── OrderService.cs
// │
// └── Utils/
//     └── InputHelper.cs