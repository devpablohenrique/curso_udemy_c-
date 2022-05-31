using System;
using System.Globalization;

namespace ex_a_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa? ");
            int numQuartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');

            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(numQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
