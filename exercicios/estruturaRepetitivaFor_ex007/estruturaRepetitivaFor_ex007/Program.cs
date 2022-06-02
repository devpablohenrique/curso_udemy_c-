using System;

namespace estruturaRepetitivaFor_ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i,3)}");
            }
        }
    }
}
