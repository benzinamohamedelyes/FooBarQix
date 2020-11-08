﻿using System;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;

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

                if (ShouldBeTreated(number, intResult))
                {
                    string tempString = number.Replace("3", "Foo").Replace("5", "Bar");
                    result = new StringBuilder(RemoveIntegers(tempString));

                    if (intResult % 3 == 0)
                        result.Insert(0, "Foo");
                    if (intResult % 5 == 0)
                        result.Insert(0, "Bar");
                    if (intResult % 7 == 0)
                        result.Insert(0, "Qix");
                }
                return result.ToString();
            }
            else
            {
                return $"{number} is not a valid Integer";
            }
        }
        private static bool ShouldBeTreated(string number, int intResult)
        {
            return number.Contains("3") ||
                number.Contains("5") ||
                intResult % 3 == 0 ||
                intResult % 5 == 0 ||
                intResult % 7 == 0;
        }
        private static string RemoveIntegers(string input)
        {
            return Regex.Replace(input, @"[\d-]", string.Empty);
        }
    }
}
