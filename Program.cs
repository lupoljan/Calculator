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
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = CalculateSum(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

            Console.ReadKey();
        }

        public static int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}
