using CSharpEnumAndCompositionChallange.Entities.Enums;
using System.Globalization;

namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class ProgramManager
    {
        public static Client GetClientData()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateOnly clientBirthDate;
            bool isValidBirthDate;

            do
            {
                isValidBirthDate = DateOnly.TryParse(
                    Console.ReadLine(),
                    out clientBirthDate);

                if (!isValidBirthDate)
                {
                    Console.WriteLine("Invalid date format." +
                        "Please enter the birth date in the format" +
                        "DD/MM/YYYY:");
                }
            } while (!isValidBirthDate);

            Client client = new(clientName, clientEmail, clientBirthDate);

            return client;
        }

        public static Order GetOrderData(Client client)
        {
            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            // Requests order status
            Console.Write("Status: ");
            OrderStatus orderStatus;
            bool isValidStatus;

            do
            {
                isValidStatus = Enum.TryParse(Console.ReadLine(),
                    out orderStatus);

                if (!isValidStatus)
                {
                    Console.WriteLine(
                        "Invalid status. Please enter a valid order status:");
                }
            } while (!isValidStatus);

            Order order = new(DateTime.Now, orderStatus, client);

            return order;
        }

        public static void GetOrderItems(Order order)
        {
            Console.Write("How many items in this order? ");
            int n;
            bool isValidQuantity;

            do
            {
                isValidQuantity = int.TryParse(Console.ReadLine(),
                    out n)
                    && n > 0;

                if (!isValidQuantity)
                {
                    Console.WriteLine("Invalid input." +
                        "Please enter a positive integer:");
                }
            } while (!isValidQuantity);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice;
                bool isValidPrice;

                do
                {
                    isValidPrice = double.TryParse(Console.ReadLine(),
                        NumberStyles.Float,
                        CultureInfo.InvariantCulture,
                        out productPrice)
                        && productPrice > 0;

                    if (!isValidPrice)
                    {
                        Console.WriteLine("Invalid input." +
                            "Please enter a positive decimal number:");
                    }
                } while (!isValidPrice);

                Product product = new(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity;
                bool isValidItemQuantity;

                do
                {
                    isValidItemQuantity = int.TryParse(Console.ReadLine(),
                        out productQuantity)
                        && productQuantity > 0;

                    if (!isValidItemQuantity)
                    {
                        Console.WriteLine("Invalid input." +
                            "Please enter a positive integer:");
                    }
                } while (!isValidItemQuantity);

                OrderItem orderItem = new(productQuantity,
                    productPrice,
                    product);

                order.AddItem(orderItem);
            }
        }

        public static void Summary(Order order)
        {
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}