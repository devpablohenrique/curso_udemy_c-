using System;
using System.Globalization;

namespace estruturaSequencial_ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe os dados da primeira peça: ");
            string[] vet1 = Console.ReadLine().Split();

            Console.Write("Informe os dados da segunda peça: ");
            string[] vet2 = Console.ReadLine().Split();

            double sub1 = double.Parse(vet1[1], CultureInfo.InvariantCulture) * double.Parse(vet1[2], CultureInfo.InvariantCulture);
            double sub2 = double.Parse(vet2[1], CultureInfo.InvariantCulture) * double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double resultado = sub1 + sub2;

            Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
