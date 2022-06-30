using Course3.Entities;
using System;
using System.Globalization;

namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            Console.Write("Enter the number of employees: "); // Quantidade de funcionarios a serem pegos os dados
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEmployee {i+1} data:");
                Console.Write("Outsourced (y/n): "); // É un funcionario da empresa, ou terceirizado?
                char verifyEmployee = char.Parse(Console.ReadLine());

                

                if (verifyEmployee == 'n')
                {
                    // Inicio dos dados do funcionario
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employees.Add(new Employee(name, hours, valuePerHour));
                }
                else if(verifyEmployee == 'y')
                {
                    // Inicio dos dados do funcionario terceirizado
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                }
                else
                {
                    Console.WriteLine("\n!The option of outsourced is only (y/n), try again!\n");
                    i--;
                }

            }

            // Printar todos os funcionarios e os valores a serem pagos a eles
            Console.WriteLine("\nPayments:");

            foreach(Employee index in Employees)
            {
                Console.WriteLine(index.Name + " - $ " + index.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}