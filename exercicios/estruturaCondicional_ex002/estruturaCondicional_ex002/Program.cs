using System;

namespace estruturaCondicional_ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro para saber se ele é par ou ímpar: ");
            int num = int.Parse(Console.ReadLine());

            if ( num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
