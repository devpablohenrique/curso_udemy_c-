using System;
using System.Globalization;

namespace ExClasseAtribMetod003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "+ aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            aluno.Aprovacao();

        }
    }
}
