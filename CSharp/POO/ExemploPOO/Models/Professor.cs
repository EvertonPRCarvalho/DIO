namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade){}
        public string Disciplina = "INDEFINIDA";

        public void NomeDisciplina()
        {
            System.Console.WriteLine($"Disciplina: {this.Disciplina}");
        }

    }

}