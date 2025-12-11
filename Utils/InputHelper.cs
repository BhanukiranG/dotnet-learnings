namespace RestaurantApp.Utils
{
    /// <summary>
    /// Provides helper methods for handling user input safely.
    /// </summary>
    public static class InputHelper
    {
        /// <summary>
        /// Reads an integer from the user.
        /// Automatically handles invalid input.
        /// </summary>
        /// <param name="message">Prompt message.</param>
        /// <returns>Parsed integer (0 if invalid).</returns>
        public static int GetInt(string message) // use extension method, try for strings
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value)) // Use TryParse to avoid exceptions
            {
                return value; // Successful parse
            }
            else
            {
                Console.WriteLine("Invalid input. Using 0 as default.");
                return 0; // Failed parse
            }
        }

    }
}
