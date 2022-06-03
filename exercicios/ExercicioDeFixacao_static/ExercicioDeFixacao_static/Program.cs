using System;
using System.Globalization;

namespace ExercicioDeFixacao_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = R${0}", ConversorDeMoeda.RealParaDolar(cotacao, dolares).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
