using System.Globalization;

namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int productQuantity,
            double productPrice,
            Product product)
        {
            Quantity = productQuantity;
            Price = productPrice;
            Product = product;
        }

        public double SubTotal()
        {
            double subTotal = Product.Price * Quantity;

            return subTotal;
        }

        public override string ToString()
        {
            return $"{Product.Name}, $" +
                Product.Price.ToString("F2", CultureInfo.InvariantCulture) +
                $", Quantity: {Quantity}, Subtotal: $" +
                SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}