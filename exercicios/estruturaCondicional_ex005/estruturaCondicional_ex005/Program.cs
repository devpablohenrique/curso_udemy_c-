using System;
using System.Globalization;

namespace estruturaCondicional_ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("CODIGO       ESPECIFICAÇÃO       PREÇO");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1            Cachorro Quente     R$ 4.00");
            Console.WriteLine("2            X-Salada            R$ 4.50");
            Console.WriteLine("3            X-Bacon             R$ 5.00");
            Console.WriteLine("4            Torrada Simples     R$ 2.00");
            Console.WriteLine("5            Refrigerante        R$ 1.50");
            Console.WriteLine("--------------------------------------------\n");
            Console.Write("Selecione um item e logo após a sua quantidade: ");
            string[] vet = Console.ReadLine().Split(' ');

            int cod = int.Parse(vet[0]);
            int qtd = int.Parse(vet[1]);

            double resultado;

            if (cod == 1)
            {
                resultado = qtd * 4;
            }
            else if (cod == 2)
            {
                resultado = qtd * 4.50;
            }
            else if (cod == 3)
            {
                resultado = qtd * 5;
            }
            else if (cod == 4)
            {
                resultado = qtd * 2;
            }
            else if (cod == 5)
            {
                resultado = qtd * 1.50;
            }
            else
            {
                resultado = 0;
            }

            if (resultado == 0)
            {
                Console.WriteLine("Codigo de produto informado é invalido!");
            }
            else
            {
                Console.WriteLine($"O valor a ser pago pelo pedido é de: R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            

        }
    }
}
