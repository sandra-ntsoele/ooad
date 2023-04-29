namespace Encapsulation
{
    class Account
    {
        public Account(string name, string address, string phone) 
        {
            owner = new Customer(name: name, address: address, phone: phone);

            Random random = new Random();
            accountNumber = random.Next(100000);
        }

        // Variables
        public Customer owner;
        private double balance;
        private int accountNumber;


        // Properties
        public double Balance
        {
            get { return balance; }
        }
        public int AccountNumber 
        {
            get { return accountNumber; }
        }

        // Methods
        public double Deposit(int Amount) {
            balance += Amount;
            return balance;
        }

        public double Withdraw(int Amount) 
        {
            if(balance >= Amount) 
            {
                balance -= Amount;
            }
            else 
            {
                Console.WriteLine("Insufficient funds");
            }
            return balance;
        }
    }
}