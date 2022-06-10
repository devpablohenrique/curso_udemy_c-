using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFixacaoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int qtdFunc = int.Parse(Console.ReadLine());

            int id;
            string nome;
            double salario;

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= qtdFunc; i++)
            {
                Console.WriteLine("Emplyoee #{0}: ", i);
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                while (funcionarios.Find(x => x.Id == id) != null)
                {
                    Console.WriteLine("Informe outro id de funcionario, id já existente!");
                    Console.WriteLine();

                    Console.WriteLine("Emplyoee #{0}: ", i);
                    Console.Write("Id: ");
                    id = int.Parse(Console.ReadLine());
                }

                Console.Write("Name: ");
                nome = Console.ReadLine();

                Console.Write("Salary: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            if (funcionarios.Find(x => x.Id == id) == null)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double persentAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Find(x => x.Id == id).AumentarSalario(persentAumento);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employess: ");
            foreach (Funcionario func in funcionarios)
            {
                Console.WriteLine(func);
            }


        }
    }
}
