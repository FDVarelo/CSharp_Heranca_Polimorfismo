namespace Course6.Entities
{
    abstract class Account
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Account()
        {

        }
        public Account(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
