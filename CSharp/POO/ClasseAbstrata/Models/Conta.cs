namespace ClasseAbstrata.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Saldo: R$ {this.saldo}");
        }
    }
}