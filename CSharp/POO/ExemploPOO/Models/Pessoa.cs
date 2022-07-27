namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string Nome {get; set;}
        public int Idade {get; set;}

       
        public void Apresentar()
        {
            System.Console.WriteLine($"Meu nome é {this.Nome} e tenho {this.Idade}");
        }
    }
}