using System;

namespace estruturaRepeticao_ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a senha: ");
            string senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.Write("Senha Invalida, tente novamente: ");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
