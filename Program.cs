using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter 10 numbers:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Enter number{i}:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    string result = (number % 2 == 0) ? "even" : "odd";
                    Console.WriteLine($"The number {number} is {result}.");
                }
        }
    }

}
