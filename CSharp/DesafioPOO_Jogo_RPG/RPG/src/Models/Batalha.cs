using RPG.Models;
namespace RPG.src.Models
{
    public class Batalha : Personagem
    {
        private Personagem jogadorUm = new Personagem();
        private Personagem jogadorDois = new Personagem();

        public Personagem JogadorUm { get => jogadorUm; set => jogadorUm = value; }
        public Personagem JogadorDois { get => jogadorDois; set => jogadorDois = value; }

        public Batalha(Personagem jogadorUm, Personagem jogadorDois)
        {
            this.JogadorUm = jogadorUm;
            this.JogadorDois = jogadorDois;
        }

        public void Atacar(Personagem oponente, string nomeAtaque)
        {
            int dano = JogadorUm.Ataques[nomeAtaque] - JogadorDois.Defesas[nomeAtaque];
            oponente.PerdeHp(dano);
        }
        public int Defender(string nomeDefesa)
        {
            try 
            {
                int contraAtaque = JogadorDois.Defesas[nomeDefesa];
                return contraAtaque;
            }
            catch(Exception)
            {
                System.Console.WriteLine("Não há defesa para este ataque.");
            }
            return 0;
        }
        public void Batalhar()
        {
            foreach (var defesa in this.JogadorUm.Defesas)
            {
                System.Console.WriteLine($"Defesa: {defesa}");
            }
            
        }

    }
}