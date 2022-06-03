using System;
using System.Globalization;

namespace ExClasseAtribMetod003
{
    internal class Aluno
    {
        public string Nome;
        public double[] Nota = new double[3];

        public double NotaFinal()
        {
            return Nota[0] + Nota[1] + Nota[2];
        }

        public void Aprovacao()
        {
            if ( NotaFinal() >= 60.00 )
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", (60.00 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
