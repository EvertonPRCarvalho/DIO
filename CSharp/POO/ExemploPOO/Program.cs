using ExemploPOO.Models;

// Pessoa p1 = new Pessoa("Everaldo", 21);
// p1.Apresentar();

// Retangulo r = new Retangulo();
// r.DefinirMedidas(5, -1);
// System.Console.WriteLine(r.ObterArea());

Aluno a1 = new Aluno("Everaldo", 23);
a1.Nota = 5;
a1.Apresentar();
a1.ExibirNota();

Professor p1 = new Professor("Antonio", 52);
p1.Disciplina = "Matemática";
p1.Apresentar();
p1.NomeDisciplina();
