using InterfacesExemplos.Interfaces;

namespace InterfacesExemplos.Models
{
    public class Calculadora : ICalculadora
    {        
        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public int Somar(int x, int y)
        {
            return x + y;
        }
        public int Somar(int x, int y, int z)
        {
            return x + y + z;
        }
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}