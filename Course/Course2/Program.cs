using System;
using System.Globalization;
using Course2.Entities;
using System.Collections.Generic;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Account acc1 = new Account(1000, "Fred", 500.0); // Erro pois agora Account é abstract, e somente pode criar
                                                                // BusinessAccount e SavingsAccount, ou seja, compa empresarial e poupança
            
            //Account acc2 = new SavingsAccount(1001, "Daniel", 500.0, 10);

            //acc1.Withdraw(100.0); // Será cobrado taxa de $ 5.0 para cada saque
            //acc2.Withdraw(100.0); // Será cobrado taxa do account padrão $ 5.0, mais a taxa do savings

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);


            // Porém para todo caso, podemos instancia a Account como lista:
            List<Account> conta = new List<Account> ();

            conta.Add(new SavingsAccount(1001, "Alex", 500.0, 10));
            conta.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            conta.Add(new SavingsAccount(1003, "Bob", 500.0, 10));
            conta.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0,sumFinal = 0;
            foreach(Account acc in conta)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total Balance: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in conta)
            {
                
                Console.Write("\nUpdated balance for account "
                    + acc.Number
                    + ": $ "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));

                acc.Withdraw(10.0); // Saca $10 de cada conta
                sumFinal += acc.Balance;

                Console.WriteLine(", To: $ "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("\nTotal Balance after withdraw: $ " + sumFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}