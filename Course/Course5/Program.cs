using System;
using System.Globalization;
using System.Collections.Generic;

using Course5.Entities;
using Course5.Entities.Enums;

namespace Course5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nShape #1 data:");
                Console.Write("Rectangle or Circle (r/c): ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                
                if(choice == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(color, width, height));
                }
                else if(choice == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
                /*else if(color != 0 && color != 1 && color != 2) // não funciona
                {
                    Console.WriteLine("\n!Color does not exist try again!\n");
                    i--;
                }*/
                else
                {
                    Console.WriteLine("\n!Only choices are: Rectangle and Circle (r/c), try again!\n");
                    i--;
                }
            }

            Console.WriteLine("\nShape Areas:");
            foreach(Shape index in list)
            {
                Console.WriteLine(index.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}