using System;
using System.Globalization;
using Course4.Entities;

namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                // Verifica o tipo de produto, comum, usado ou importado
                Console.WriteLine($"\nProduct #{i+1} data:");
                Console.Write("Common, user or imported (c/u/i): ");
                char letter = char.Parse(Console.ReadLine());

                if(letter == 'c') // comum
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new Product(name,price));
                }
                else if(letter == 'u') // usado
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM//YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name,price,date));
                }
                else if(letter == 'i') // importado
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Custom fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    Console.WriteLine("\n!Only possible choices → (c/u/i), try again!\n");
                    i--;
                }
            }

            Console.WriteLine("\nPrice Tags:");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}