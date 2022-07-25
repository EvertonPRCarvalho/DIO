
static void CriarCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");
   

    var pessoas = new List<Pessoa>(){
        new Pessoa(){
            Nome       = "José da Silva",
            Email      = "js@gmail.com",
            Telefone   = 123456,
            Nascimento = new DateOnly(year: 1970, month: 02, day: 02)
        },
        new Pessoa(){
            Nome       = "Pedro Paiva",
            Email      = "pp@gmail.com",
            Telefone   = 456789,
            Nascimento = new DateOnly(year: 2002, month: 04, day: 20)
        },
    }; 

    var di = new DirectoryInfo(path);
    if(!di.Exists)
    {
        di.Create();
        path = Path.Combine(path, "usuarios.csv");
    }
    using var sw = new StreamWriter(path);
    sw.WriteLine("nome, email, telefone, nascimento");
    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }
}

// static void LerCsv()
// {
//     var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuario-exportacao.csv");
//     using var sr = new StreamReader(path);
//     var cabecalho = sr.ReadLine()?.Split(',');
//     //cabecalho: nome | email | telefone | nascimento
//         if (File.Exists(path))
//     {
//         while (true)
//         {
//             var registro = sr.ReadLine()?.Split(',');
//             if(registro == null) break;
//             for (int i = 0; i < registro.Length; i++)
//             {
//                 System.Console.WriteLine($"{cabecalho[i]}: {registro[i]}");
//             }
//             System.Console.WriteLine("----------------------");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine($"O arquivo {path} não existe!");
//     }
//     System.Console.WriteLine("\n\nPressione [ENTER] para finalizar...");
// }

CriarCsv();
//LerCsv();

class Pessoa
{
    public string? Nome {get; set;}
    public string? Email {get; set;}
    public int? Telefone {get; set;}
    public DateOnly Nascimento {get; set;}
}