using System;
using System.Globalization;

namespace estruturaRepetitivaFor_ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quanditdade de pares a serem lidos: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                string[] vet = Console.ReadLine().Split();

                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

                if ( n2 == 0)
                {
                    Console.WriteLine("Divisão impossivel!");
                }
                else
                {
                    double resultado = n1 / n2;
                    Console.WriteLine(resultado.ToString(CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
