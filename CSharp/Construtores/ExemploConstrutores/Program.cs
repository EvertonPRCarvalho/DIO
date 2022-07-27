using ExemploConstrutores.Models;
using static ExemploConstrutores.Models.Calculadora;

//Evento
Matematica mt = new Matematica(10, 20);
mt.Somar();


//MultiCast Delegate
// Operacao op = new Operacao(Calculadora.Somar);
// op += Calculadora.Subtrair;
// op.Invoke(10,10);
//DELEGATE 

// Operacao op = new Operacao(Calculadora.Somar);
// op.Invoke(10,10);
// System.Console.WriteLine(op);
// Data data1 = new Data();
// data1.RegistrarMes(-1);

// Pessoa p1 = new Pessoa("Everton", "Carvalho");
// p1.Apresentar();
// Aluno a1 = new Aluno("Everton", "Carvalho", "MD");
//Pessoa p2 = new Pessoa();

// Log log = Log.GetInstance();
// log.PropriedadeLog = "Teste instância";
// Log log2 = Log.GetInstance();
// System.Console.WriteLine(log2.PropriedadeLog);