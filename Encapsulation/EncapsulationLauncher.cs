namespace Encapsulation
{
    class EncapsulationLauncher
    {
        public EncapsulationLauncher()
        {
            Console.WriteLine("=== Welcome to the bank ===");

            string Name = GetName();
            string Address = GetLocation();
            string Phone = GetPhone();

            Account account = new Account(Name, Address, Phone);

            Console.WriteLine($"Account succesfully created");
            Console.WriteLine($"Owned by: {account.owner.Name}");
        }

        private string GetName() {
            string Name = "";

            while (string.IsNullOrEmpty(Name))
            {
                Console.Write("What's your name: ");
                Name = Console.ReadLine() ?? "";
            }
            return Name;
        }

        private string GetLocation() {
            string location = "";

            while (string.IsNullOrEmpty(location))
            {
                Console.Write("Where do you live: ");
                location = Console.ReadLine() ?? "";
            }
            return location;
        }

        private string GetPhone() {
            string phone = "";

            while (string.IsNullOrEmpty(phone) || phone.Length < 10)
            {
                Console.Write("What's your phone number: ");
                phone = Console.ReadLine() ?? "";
            }
            return phone;
        }
    }
}