using System;
using System.Globalization;

namespace estruturaSequencial_ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira 3 valores na mesma linha, separados por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double resultA = a * c / 2;
            double resultB = pi * (Math.Pow(c, 2));
            double resultC = ((a + b) * c ) / 2;
            double resultD = Math.Pow(b, 2);
            double resultE = a * b;

            Console.WriteLine($"TRIANGULO: {resultA.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {resultB.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {resultC.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {resultD.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {resultE.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
