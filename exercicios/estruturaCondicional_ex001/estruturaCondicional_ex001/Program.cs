using System;

namespace estruturaCondicional_ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero inteiro para saber se é positivo ou negativo: ");
            int num = int.Parse(Console.ReadLine());

            if ( num < 0)
            {
                Console.WriteLine($"O numero informado {num} é NEGATIVO");
            }
            else
            {
                Console.WriteLine($"O numero informado {num} é POSITIVO");
            }
        }
    }
}
