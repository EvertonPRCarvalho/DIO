namespace RPG.Models
{
    public class Personagem
    {
        private string nome = string.Empty;
        private string tipoHeroi = string.Empty;
        private int level = 1;
        private int hp = 10;
        private Dictionary<string, int> defesas = new Dictionary<string, int>();//Conjunto de ataque que o personagem é capaz de defender e o valor que é possível defender.
        private Dictionary<string, int> ataques = new Dictionary<string, int>();//Conjunto de ataque que o personagem é capaz de fazer e seu respectivo dano.
        protected bool alive = true;

        public Personagem(){}
        public Personagem(string nome, string tipoHeroi)
        {
            this.Nome = nome;
            this.TipoHeroi = tipoHeroi;
        }

        public string Nome { get => nome; set => nome = value; }
        public string TipoHeroi { get => tipoHeroi; set => tipoHeroi = value; }
        public int Level { get => level; set => level = value; }
        public int Hp { get => hp; set => hp = value; }
        protected bool Alive { get => alive; set => alive = value; }
        public Dictionary<string, int> Defesas { get => defesas; set => defesas = value; }
        public Dictionary<string, int> Ataques { get => ataques; set => ataques = value; }

        public void AdicionarAtaque(string tipo, int dano)
        {
            Ataques.Add(tipo, dano);
        }
        public void AdicionarDefesa(string tipo, int dano)
        {
            Defesas.Add(tipo, dano);
        }
        
        public void ListarAtaques()
        {
            foreach (var ataque in this.Ataques)
            {
                System.Console.WriteLine($"Ataque: {ataque.Key} | Dano: {ataque.Value}");
            }
        }
        public void ListarDefesas()
        {
            foreach (var defesa in this.Defesas)
            {
                System.Console.WriteLine($"Defesa: {defesa.Key} | Contra-ataque: {defesa.Value}");
            }
        }

        public bool PerdeHp(int dano)
        {
            if (this.Hp <= 0)
            {
                this.Alive = false;
                return Alive;
            }
            else
            {
                this.Hp -= dano;
                return Alive;
            }
            
        }
        public void GanhaHp(int hp)
        {
            this.Hp += hp;
        }
        public virtual void Jargao()
        {
          System.Console.WriteLine("É prudente manter-se calado.");  
        }
    }
}