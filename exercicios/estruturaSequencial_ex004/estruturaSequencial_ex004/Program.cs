using System;
using System.Globalization;

namespace estruturaSequencial_ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu numero de funcionario: ");
            int numF = int.Parse(Console.ReadLine());

            Console.Write("Informe o seu número de horas trabalhadas: ");
            double numH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o valor a ser pago por cada hora: ");
            double valH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = numH * valH;

            Console.WriteLine($"NUMBER = {numF}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
