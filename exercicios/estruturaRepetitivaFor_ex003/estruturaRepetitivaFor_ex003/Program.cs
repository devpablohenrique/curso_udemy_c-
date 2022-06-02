using System;
using System.Globalization;

namespace estruturaRepetitivaFor_ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o numero de casos para ser avaliado: ");
            int qtdCasos = int.Parse(Console.ReadLine());

            double[] result = new double[qtdCasos] ;

            for ( int i = 0; i < qtdCasos; i++)
            {
                Console.Write("Informe na mesma linha as três notas, para o caso #{0}: ", i+1);
                string[] vet = Console.ReadLine().Split(' ');

                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                result[i] = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            }

            for (int i = 0; i < qtdCasos; i++)
            {
                Console.WriteLine($"A media ponderada para o caso #{i+1} é de: {result[i].ToString("F1", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
