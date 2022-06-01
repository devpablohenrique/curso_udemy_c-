using System;
using System.Globalization;

namespace estruturaSequencial_ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
