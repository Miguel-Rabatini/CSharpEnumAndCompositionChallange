namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class Client
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateOnly BirthDate { get; private set; }

        public Client()
        {
        }

        public Client(string clientName,
            string clientEmail,
            DateOnly clientBirthDate)
        {
            Name = clientName;
            Email = clientEmail;
            BirthDate = clientBirthDate;
        }

        public override string ToString()
        {
            return $"{Name}, ({BirthDate}) - {Email}";
        }
    }
}