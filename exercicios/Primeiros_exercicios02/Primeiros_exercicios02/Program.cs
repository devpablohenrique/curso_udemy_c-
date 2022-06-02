using System;
using System.Globalization;

namespace Primeiros_exercicios02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSal = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("Salário médio = {0}", mediaSal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
