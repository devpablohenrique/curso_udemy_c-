using System;

namespace estruturaRepeticao_ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Informe o tipo de combustivel abastecido, de acordo com a lista:");
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("----------------------------------------------------------------------------\n");

            int opc = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (opc != 4)
            {
                if (opc == 1)
                {
                    alcool++;
                }
                else if (opc == 2)
                {
                    gasolina++;
                }
                else if (opc == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Opção invalida, selecione novamente!");
                }

                opc = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMUITO OBRIGADO");
            Console.WriteLine("Alcool: {0}", alcool);
            Console.WriteLine("Gasolina: {0}", gasolina);
            Console.WriteLine("Diesel: {0}", diesel);
        }
    }
}
