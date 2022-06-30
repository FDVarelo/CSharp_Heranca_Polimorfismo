using System;
using System.Globalization;
using System.Collections.Generic;

using Course6.Entities;

namespace Course6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            Console.Write("The number of taxes payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nTax payer #{i + 1} data:");

                Console.Write("Individual or Company (i/c): ");
                char typeAccount = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("AnnualIncome: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeAccount == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    accounts.Add(new Individual(name, income, expenditure));
                }
                else if (typeAccount == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine());
                    accounts.Add(new Company(name, income, numberEmployee));
                }
                else
                {
                    Console.WriteLine("\n!This type of account doesn't exist, try again!\n");
                    i--;
                }
            }

            Console.WriteLine("Taxes Paid:");
            double sum = 0;
            foreach (Account account in accounts)
            {
                Console.WriteLine(account.Name
                    + ": $"
                    + account.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += account.Tax();
            }
            Console.WriteLine("\nTotal Taxes: $ " + sum.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}