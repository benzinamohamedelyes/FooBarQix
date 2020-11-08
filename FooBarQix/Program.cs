using System;
using System.Runtime;
using System.Text;

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
            if (int.TryParse(number, out int intResult))
            {

                StringBuilder result = new StringBuilder(number);
                if (intResult % 3 == 0)
                    result = new StringBuilder("Foo");
                if (intResult % 5 == 0)
                    result = new StringBuilder("Bar");
                
                return result.ToString();
            }
                
            else
                return $"{number} is not a valid Integer";
        }
    }
}
