using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");


            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int sum = CalculateDifference(a, b);
            Console.WriteLine($"{a} - {b} = {sum}");
            Console.ReadKey();
        }

        public static int CalculateDifference(int a, int b)
        {
            return a - b;
        }
    }
}
