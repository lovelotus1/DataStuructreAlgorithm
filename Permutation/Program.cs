using System;

namespace Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n5.Permutation");
                int option = Convert.ToInt32(Console.ReadLine());

                //Permutation
                Permutation1 permutation = new Permutation1();
                String str = "Vaibhav";
                int Outputs = str.Length;
                Permutation1.Permute(str, 0, Outputs - 1);
                Console.ReadKey();
            }
        }
    }
}