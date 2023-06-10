namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product()
        {
        }

        public Product(string productName, double productPrice)
        {
            Name = productName;
            Price = productPrice;
        }
    }
}