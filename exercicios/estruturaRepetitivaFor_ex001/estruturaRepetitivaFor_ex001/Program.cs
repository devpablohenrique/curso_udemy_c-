using System;

namespace estruturaRepetitivaFor_ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor inteiro, onde seja maior que 0 e menor/igual a 1000: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if ( i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
