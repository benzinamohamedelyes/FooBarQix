using System;
using System.Runtime;

namespace FooBarQix
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Compute(args[0]));
            Console.ReadKey();
        }
        public static string Compute(string number)
        {
            if (int.TryParse(number, out int result))
                return number;
            else
                return $"{number} is not a valid number";
        }
    }
}
