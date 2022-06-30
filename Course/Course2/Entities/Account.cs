namespace Course2.Entities
{
    abstract class Account
    {
        public int Number { get; set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) // Withdraw Pode ser Sobrescrito(virtal) pelas subclasses
        {
            Balance -= amount + 5.0; // É cobrado uma taxa de $ 5.0 de cada saque
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}