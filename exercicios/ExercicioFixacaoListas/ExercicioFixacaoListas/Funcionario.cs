using System.Globalization;

namespace ExercicioFixacaoListas
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario ()
        {

        }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            AumentarSalario(salario);
        }

        public void AumentarSalario(double valor)
        {
            if (Salario == 0.0)
            {
                Salario = valor;
            }
            else
            {
                Salario += Salario * (valor / 100);
            }  
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
