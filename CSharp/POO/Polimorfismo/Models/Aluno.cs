namespace Polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade, string documento) : base(nome, idade, documento){}
        public int Nota { get; set; }
        public override void Apresentar() //'override' garante que seja possível a sobrescrita do método
        {
            System.Console.WriteLine($"Meu nome é {this.Nome} e tenho {this.Idade}. Minha nota foi {this.Nota}.");
        }
        public void ExibirNota()
        {
                System.Console.WriteLine($"Nota: {this.Nota}");
        }
    }
}