using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * BusinessAccount accountBusiness = new BusinessAccount(8822, "Alex Gomes", 500.00, 1000.00);
            Account accountUser = new Account(8846, "Fred Varelo", 1200.00);

            Console.WriteLine($"> Account: {accountUser.Number} from {accountUser.Holder} has ${accountUser.Balance} in the accountBusiness.\n");
            Console.WriteLine($"> The Business Account: {accountBusiness.Number} from {accountBusiness.Holder} has ${accountBusiness.Balance} in the account, and can loan the maximun ammount of ${accountBusiness.LoanLimit}.\n");
            Console.Write($"> Ammount of loan for the  Business Account {accountBusiness.Number}: ");
            double amount = double.Parse(Console.ReadLine());
            accountBusiness.Load(amount);
            Console.WriteLine($"\n> Updated Balance for Business Account {accountBusiness.Number}: ${accountBusiness.Balance}");
            */

            //  EXEMPLO FEITO PARA TESTE ↑

            // ***************************** //

            //  EXEMPLO DO CURSO ↓

            Account acc = new Account(8822, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(8846, "Empresa de Programação", 0.0, 500.0);

            //↓ UPCASTING

            //↓ Account recebe uma BusinessAccount (OK)
            Account acc1 = bacc;

            //↓ Cria uma Account, porém passa os dados de uma Business Account (OK)
            Account acc2 = new BusinessAccount(1000, "Testando acc com bacc", 0.0, 1000.0);
            Account sacc1 = new SavingsAccount(1001, "Testando acc com sacc", 0.0, 1);




            /*↓ DOWNCASTING
                É uma operação insegura, pois pode ocorrer de eu fazer por exemplo,
                uma Entidade BusinessAcc receber dados de uma SavingsAcc, onde não tem herança entre ambas.*/

            //↓ Impossivel fazer uma bacc receber dados de uma acc, apesar da acc2 estar recebendo dados de uma bacc
            // BusinessAccount bacc1 = acc2;

            // Para isso é necessário fazer o downcasting da seguinte forma ↓
            BusinessAccount bacc1 = (BusinessAccount)acc2; // Desta forma ele recebe os dados da acc
                                                           // como se fosse uma bacc
                                                           
            BusinessAccount bacc_x = acc2 as BusinessAccount; // outra forma de sintaxe

            bacc1.Loan(100.0); // Possivel fazer pois é uma bacc

            //acc2.Loan(200.0); // Impossivel fazer, apesar de acc receber dados da bacc,
            // para isso é preciso fazer o downcasting


            //BusinessAccount bacc2 = (BusinessAccount)sacc1; // sacc1 → SavingsAccount
            // Compilador não vai dar erro, porém quando for rodar ele encontrada um erro
            // pois o bacc2 (BusinessAccount) está recebendo dados do sacc1 (SavingsAccount)

            //Então para isso utilizamos ↓
            if(sacc1 is BusinessAccount) // verificar se a variavel sacc1 é uma instância de BusinessAccount
            {
                BusinessAccount bacc2 = (BusinessAccount)sacc1; // Caso seja, então continue
                bacc2.Loan(200.0);
                Console.WriteLine("Loan was a Success!");
            }

            if(sacc1 is SavingsAccount)
            {
                SavingsAccount sacc2 = (SavingsAccount)sacc1;
                sacc2.UpdateBalance();
                Console.WriteLine("Update Balance was a Success!");
            }
        }
    }
}