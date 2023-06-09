using CSharpEnumAndCompositionChallange.Entities.Enums;
using System.Globalization;

namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class ShowProgram
    {
        // Show the program into the Program.cs
        public static void Show()
        {
            // Requests the client data
            Console.WriteLine("Enter client data:");
            // Requests the client name
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            // Request the client email
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            // Requests the client birth date
            Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateOnly clientBirthDate;
            bool isValidBirthDate;

            // Loop that checks if the date of birth has valid format
            do
            {
                // Gets the client's birth date and checks if it's valid
                isValidBirthDate = DateOnly.TryParse(Console.ReadLine(), out clientBirthDate);

                // If the birth day format isn't valid, shows the alert message
                if (!isValidBirthDate)
                {
                    Console.WriteLine("Invalid date format. Please enter the birth date in the format DD/MM/YYYY:");
                }
            } while (!isValidBirthDate);

            // Creates new client
            Client client = new(clientName, clientEmail, clientBirthDate);

            // Requests the order data
            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            // Requests order status
            Console.Write("Status: ");
            OrderStatus orderStatus;
            bool isValidStatus;

            // Loop that checks if the order status input is valid
            do
            {
                // Gets the order status and checks if it's valid
                isValidStatus = Enum.TryParse(Console.ReadLine(), out orderStatus);

                // If the status input isn't valid, shows the alert message
                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid status. Please enter a valid order status:");
                }
            } while (!isValidStatus);

            // Creates new order
            Order order = new(DateTime.Now, orderStatus, client);

            // Requests the quantity of order items
            Console.Write("How many items in this order? ");
            int n;
            bool isValidQuantity;

            // Loop that checks if the quantity of items is valid
            do
            {
                // Gets the quantity of items and checks if it's valid
                isValidQuantity = int.TryParse(Console.ReadLine(), out n) && n > 0;

                // If the quantity os items isn't valid, shows alert message
                if (!isValidQuantity)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer:");
                }
            } while (!isValidQuantity);

            // Runs the same amount of times as items
            for (int i = 1; i <= n; i++)
            {
                // Request the items data
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                // Requests the item name
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                // Requests the item price
                Console.Write("Product price: ");
                double productPrice;
                bool isValidPrice;

                // Loop that checks if the Product price is valid
                do
                {
                    // Gets the product price and checks if it's valid
                    isValidPrice = double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out productPrice) && productPrice > 0;

                    // If the product Price isn't valid, shows alert message
                    if (!isValidPrice)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive decimal number:");
                    }
                } while (!isValidPrice);

                // Creates the product
                Product product = new(productName, productPrice);

                // Requests the quantity of the product
                Console.Write("Quantity: ");
                int productQuantity;
                bool isValidItemQuantity;

                // Loop that checks if the quantity of the products is valid
                do
                {
                    // Gets the quantity of products and check if it's valid
                    isValidItemQuantity = int.TryParse(Console.ReadLine(), out productQuantity) && productQuantity > 0;

                    // If the quantity of products isn't valid, shows the alert message
                    if (!isValidItemQuantity)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive integer:");
                    }
                } while (!isValidItemQuantity);

                // Creates the order item
                OrderItem orderItem = new(productQuantity, productPrice, product);

                // Add the order item into the order
                order.AddItem(orderItem);
            }

            // Shows order summary
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}