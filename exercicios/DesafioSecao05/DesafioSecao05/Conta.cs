using System.Globalization;

namespace DesafioSecao05
{
    internal class Conta
    {
        private double Taxa = 5.00;

        public string NomeCliente { get; set; }
        public int NumConta { get; private set; } 
        public double Saldo { get; private set; }

        public Conta()
        {
            Saldo = 0.0;
        }

        public Conta(int numConta, string nomeCliente) : this()
        {
            NumConta = numConta;
            NomeCliente = nomeCliente;
        }

        public Conta(int numConta, string nomeCliente, double saldo) : this(numConta, nomeCliente)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= (valor + Taxa);
        }

        public override string ToString()
        {
            return "Conta " + NumConta +
                ", Titular: " + NomeCliente +
                ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
