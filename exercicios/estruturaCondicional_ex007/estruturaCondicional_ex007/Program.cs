using System;
using System.Globalization;

namespace estruturaCondicional_ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira dois valores REAIS: ");
            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if ( x == 0 )
            {
                Console.WriteLine("Eixo X");
            }
            else if ( y == 0)
            {
                Console.WriteLine("Eito Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if ( x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if ( x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("Q3");
            }
        }
    }
}
