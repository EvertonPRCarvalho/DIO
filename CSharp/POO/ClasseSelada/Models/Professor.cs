namespace ClasseSelada.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade, string documento) : base(nome, idade, documento){}
        public string Disciplina = "INDEFINIDA";

        public sealed void NomeDisciplina() //'sealed' garante que este método não poderá ser herdado por outra classe. O mesmo princípio pode ser aplicado a própria classe Professor, impedindo-a de ter classes filhas.
        {
            System.Console.WriteLine($"Disciplina: {this.Disciplina}");
        }

        public override void Apresentar() //'override' garante que seja possível a sobrescrita do método
        {
            System.Console.WriteLine($"Meu nome é {this.Nome} e tenho {this.Idade}. Ministro a disciplina {this.Disciplina}.");
        }

    }

}