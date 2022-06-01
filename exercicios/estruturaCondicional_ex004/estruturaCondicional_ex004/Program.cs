using System;

namespace estruturaCondicional_ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a hora inicial e a hora final do jogo: ");
            string[] vet = Console.ReadLine().Split();

            int inicial = int.Parse(vet[0]);
            int final = int.Parse(vet[1]);

            if (inicial >= final)
            {
                Console.WriteLine($"O JOGO DUROU {24 - inicial + final} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU { final - inicial} HORA(S)");
            }

        }
    }
}
