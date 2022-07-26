using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Place
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter adress:");
            Console.WriteLine("Index:");
            Adress Adress = new Adress();
            Adress.Index = Console.ReadLine();
            Console.WriteLine("Country:");
            Adress.Country = Console.ReadLine();
            Console.WriteLine("City:");
            Adress.City = Console.ReadLine();
            Console.WriteLine("Street:");
            Adress.Street = Console.ReadLine();
            Console.WriteLine("House: ");
            Adress.House = Console.ReadLine();
            Console.WriteLine("Apartment: ");
            Adress.Apartment = Console.ReadLine();
            Console.WriteLine(Adress.Index);
            Adress.PrintStatus();
            Console.ReadLine();
        }
    }
}
