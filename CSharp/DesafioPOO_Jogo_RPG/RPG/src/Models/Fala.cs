using RPG.Models;

namespace RPG.src.Models
{
    public class Fala : Personagem
    {
        private string texto = string.Empty;

        public Fala(){}

        public string Texto { get => texto; set => texto = value; }

        public override void Jargao()
        {
            System.Console.WriteLine("Por vezes, manter-se em silêncio é a melhor opção.");
        }
        public void Falar(string nome, string texto)
        {
            System.Console.WriteLine($"{nome}: {texto}");
        }
        

    }
}