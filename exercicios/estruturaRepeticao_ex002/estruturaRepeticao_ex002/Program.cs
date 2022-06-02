using System;
using System.Globalization;

namespace estruturaRepeticao_ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultado = "a";

            while (resultado != "")
            {
                Console.Write("Insira dois valores para calcularmos a posição no plano cartesiano: ");
                string[] vet = Console.ReadLine().Split(' ');

                double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

                resultado = Quadran(x, y);

                Console.WriteLine(resultado);
            }
        }

        static string Quadran(double a, double b)
        {
            string result;

            if (a == 0 || b == 0)
            {
                result = "";
            }
            else if (a > 0 && b > 0)
            {
                result = "primeiro";
            }
            else if (a < 0 && b > 0)
            {
                result = "segundo";
            }
            else if (a < 0 && b < 0)
            {
                result = "terceiro";
            }
            else
            {
                result = "quarto";
            }

            return result;
        }
    }
}
