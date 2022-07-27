namespace ClasseSelada.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade, string documento)
        {
            Nome = nome;
            Idade = idade;
            Documento = documento;
        }

        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Documento {get; set;}

       
        public virtual void Apresentar() //'virtual' garante que seja possível sobrescrever o método
        {
            System.Console.WriteLine($"Meu nome é {this.Nome} e tenho {this.Idade}");
        }
    }
}