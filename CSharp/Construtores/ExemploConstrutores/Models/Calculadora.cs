namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();
        //Evento
        public static event DelegateCalculadora EventoCalculadora;

        //public delegate int Operacao(int x, int y);
        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"SOMA: {x+y}");   
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito!");
            }
        }
        public static int Subtrair(int x, int y)
        {
            System.Console.WriteLine($"SOMA: {x-y}");
            return x - y;
        }
    }
}