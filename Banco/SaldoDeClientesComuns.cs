namespace Banco
{
    public class SaldoDeClientesComuns
    {

        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo >= 0)
            {
                this.saldo = saldo;
            }
        }

        public double ObterSaldo()

        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < 100)
            {
                return false;
            }

            saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, SaldoDeClientesComuns ContaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                ContaDestino.Depositar(valor);
                return true;
            }

        }
    }
}
