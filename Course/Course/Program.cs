using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount accountBusiness = new BusinessAccount(8822, "Alex Gomes", 500.00, 1000.00);
            Account accountUser = new Account(8846, "Fred Varelo", 1200.00);

            Console.WriteLine($"> Account: {accountUser.Number} from {accountUser.Holder} has ${accountUser.Balance} in the accountBusiness.\n");
            Console.WriteLine($"> The Business Account: {accountBusiness.Number} from {accountBusiness.Holder} has ${accountBusiness.Balance} in the account, and can loan the maximun ammount of ${accountBusiness.LoanLimit}.\n");
            Console.Write($"> Ammount of loan for the  Business Account {accountBusiness.Number}: ");
            double amount = double.Parse(Console.ReadLine());
            accountBusiness.Load(amount);
            Console.WriteLine($"\n> Updated Balance for Business Account {accountBusiness.Number}: ${accountBusiness.Balance}");
        }
    }
}