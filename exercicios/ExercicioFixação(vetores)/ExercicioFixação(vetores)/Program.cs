using System;

namespace ExercicioFixação_vetores_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] vet = new Aluguel[10];

            string nome;
            string email;
            int quarto;

            Console.Write("How many rooms will be rented? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < qtdQuartos; i++)
            {
                Console.WriteLine("Rent #{0}", i+1);
                Console.Write("Name: ");
                nome = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Room: ");
                quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vet[quarto] = new Aluguel { Nome = nome, Email = email }; 
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine($"{i}: {vet[i].Nome}, {vet[i].Email}");
                }
            }
        }
    }
}
