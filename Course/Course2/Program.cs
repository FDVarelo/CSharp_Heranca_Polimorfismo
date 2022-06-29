using System;
using Course2.Entities;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1000, "Fred", 500.0);
            Account acc2 = new SavingsAccount(1001, "Daniel", 500.0, 10);

            acc1.Withdraw(100.0); // Será cobrado taxa de $ 5.0 para cada saque
            acc2.Withdraw(100.0); // Será cobrado taxa do account padrão $ 5.0, mais a taxa do savings

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}