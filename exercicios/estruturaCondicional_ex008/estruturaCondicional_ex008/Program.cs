using System;
using System.Globalization;

namespace estruturaCondicional_ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salario para calcularmos o imposto de renda: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = 0.0;

            if ( salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if ( salario <= 3000.00)
            {
                resultado = salario - 2000.00;
                resultado = resultado * 0.08;
                Console.WriteLine("R$ {0}", resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500)
            {
                // 8% de 1000 = 80
                resultado = salario - 3000.00;
                resultado = resultado * 0.18 + 80.00;
                Console.WriteLine("R$ {0}", resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                // 18% de 1500 = 270
                resultado = salario - 4500.00;
                resultado = resultado * 0.28 + 80.00 + 270.00;
                Console.WriteLine("R$ {0}", resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
