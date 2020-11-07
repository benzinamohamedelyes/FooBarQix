using System;

namespace FooBarQix
{
    public class Program
    {
        static void Main(string[] args)
        {

            Compute(args[0]);
        }
        public static void Compute(string number)
        {
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
