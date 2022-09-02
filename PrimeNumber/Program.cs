using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Problems");
            Console.WriteLine("Press 6 for Primenumber Problem");
            int option = Convert.ToInt32(Console.ReadLine());

            PrimeNumberRange pnum = new PrimeNumberRange();
            pnum.Prime();
        }
    }
}