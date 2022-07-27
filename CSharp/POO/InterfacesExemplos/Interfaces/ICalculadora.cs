namespace InterfacesExemplos.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int x, int y);
        int Subtrair(int x, int y);
        int  Multiplicar(int x, int y);
        int Dividir(int x, int y) //Não é preciso implementar em Calculadora, pois já foi feito aqui. Isso não se aplica aos demais métodos que não foram implementados como, Subtrair, Multiplicar e Somar.
        {
            return x / y;
        }
    }
}