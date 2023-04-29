namespace Encapsulation
{
    class Customer
    {
        public Customer(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        private string name;
        private string address;
        private string phone;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Address 
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone 
        {
            get { return phone; }
            set 
            {
                if(value.Length < 10) {
                    Console.WriteLine("Invalid phone length");
                }
                else 
                {
                    phone = value;
                }
            }
        }
    }
}