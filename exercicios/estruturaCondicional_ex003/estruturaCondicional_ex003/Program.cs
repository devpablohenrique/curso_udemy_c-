using System;

namespace estruturaCondicional_ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois valores inteiro: ");
            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if ( a > b)
            {
                if (a % b == 0)
                {
                    Console.WriteLine("São Multiplos");
                }
                else
                {
                    Console.WriteLine("Não são Multiplos");
                }
            }
            else
            {
                if (b % a == 0)
                {
                    Console.WriteLine("São Multiplos");
                }
                else
                {
                    Console.WriteLine("Não são Multiplos");
                }
            }
            
        }
    }
}
