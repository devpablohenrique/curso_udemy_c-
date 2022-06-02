using System;

namespace estruturaRepetitivaFor_ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor para ser calculado o seu fatoria: ");
            int num = int.Parse(Console.ReadLine());

            int fatorial = 1;

            if (num == 0 || num == 1)
            {
                Console.WriteLine("O fatorial de {0} é 1", num);
            }
            else
            {
                for (int i = 1; i < num; i++)
                {
                    fatorial = fatorial * (i + 1);
                }
                Console.WriteLine("O fatorial de {0} é {1}", num, fatorial);
            }
            
        }
    }
}
