namespace Course.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) // Aproveitamento
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("\n> !You exceded the amount o load that can be used!");
            }
        }
    }
}