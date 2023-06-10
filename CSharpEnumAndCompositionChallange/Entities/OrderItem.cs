using System.Globalization;

namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class OrderItem
    {
        private int _quantity;
        public double Price { get; private set; }
        public Product Product { get; private set; }

        public int Quantity
        {
            get { return _quantity; }
            private set
            {
                if (value > 0)
                    _quantity = value;
            }
        }

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
            double subTotal = Price * Quantity;

            return subTotal;
        }

        public override string ToString()
        {
            return $"{Product.Name}, $" +
                Price.ToString("F2", CultureInfo.InvariantCulture) +
                $", Quantity: {Quantity}, Subtotal: $" +
                SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}