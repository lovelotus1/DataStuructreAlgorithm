using System;

namespace Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string");
            string pincode = Console.ReadLine();
            Patterns patterns = new Patterns();
            if (patterns.validatePinCode(pincode))
                Console.WriteLine("Pattern Matched");
            else
                Console.WriteLine("Pattern Not Matched");
        }
    }
}