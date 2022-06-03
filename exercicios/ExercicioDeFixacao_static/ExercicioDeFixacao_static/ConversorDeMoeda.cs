using System;

namespace ExercicioDeFixacao_static
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double RealParaDolar(double cotacao, double qtdDolar)
        {
            double saldoParcial = qtdDolar * cotacao;

            return saldoParcial += saldoParcial * Iof;
        }
    }
}
