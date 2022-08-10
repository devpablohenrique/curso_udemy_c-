using System;
using System.Globalization;

namespace exercicio_fixacao_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}
