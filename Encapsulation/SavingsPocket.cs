namespace Encapsulation
{
    class SavingsPocket: Account
    {
        public SavingsPocket(string name, string address, string phone, string PocketName): base(name, address, phone)
        {
            this.pocketName = PocketName;
        }
        private string pocketName;
        private double goalAmount;

        public double GoalAmount 
        {
            get { return goalAmount; }
            set { goalAmount = value; }
        }        
    }
}