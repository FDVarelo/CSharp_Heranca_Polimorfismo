namespace Course2.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * (InterestRate / 100);
        }

        public override void Withdraw(double amount) // Sobrescrever(override) o Withdraw de Acc com o de SavingsAcc
        {
            base.Withdraw(amount); // Pega o Withdraw da superclasse + ↓
            Balance -= 0.1; // Cobrado taxa em cima do Balance que foi pego da superclasse
        }
    }
}
