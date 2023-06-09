namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

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