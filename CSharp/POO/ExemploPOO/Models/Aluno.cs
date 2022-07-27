namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade){}
        public int Nota { get; set; }
        public void ExibirNota()
        {
                System.Console.WriteLine($"Nota: {this.Nota}");
        }
    }
}