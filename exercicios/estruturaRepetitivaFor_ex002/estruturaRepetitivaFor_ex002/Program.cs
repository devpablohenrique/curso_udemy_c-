using System;

namespace estruturaRepetitivaFor_ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quantos valores serão lidos: ");
            int n = int.Parse(Console.ReadLine());

            int valIn = 0;
            int valOut = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Informe o valor #{0}: ", i);
                int val = int.Parse(Console.ReadLine());

                if ( val >= 10 && val <= 20)
                {
                    valIn++;
                }
                else
                {
                    valOut++;
                }
            }
            Console.WriteLine($"{valIn} in");
            Console.WriteLine($"{valOut} out");
        }
    }
}
