namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDate { get; set; }

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