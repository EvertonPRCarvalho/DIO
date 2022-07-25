using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

static void LerCSVComDynamic(){

    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "Produto.csv" );

    var fi = new FileInfo(path);

    if (!fi.Exists) //Verifica se o arquivo existe
    {
        throw new FileNotFoundException($"O arquivo {path} não existe!");
    }

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        System.Console.WriteLine($"nome:{registro.Produto}");
        System.Console.WriteLine($"nome:{registro.Marca}");
        System.Console.WriteLine($"nome:{registro.Preco}");
        System.Console.WriteLine($"======================");
    }
}
static void LerCsvComClasse(){
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada","novos-usuarios.csv");
    var fi = new FileInfo(path);
    if (!fi.Exists)
    {
  //      throw new LerCSVComDynamic();
    }
    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        System.Console.WriteLine($"nome:{registro.Nome}");
        System.Console.WriteLine($"email:{registro.Email}");
        System.Console.WriteLine($"telefone:{registro.Telefone}");
        System.Console.WriteLine($"======================");
    }
}
static void EscreverCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");
    var di = DirectoreInfo(path);

    if (!di.Exists) di.Create();
    path = Path.Combine(path, "usuario.csv");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "José da Silva",
            Email = "js@gmail.com",
            Telefone = "123654"
        },
        new Pessoa()
        {
            Nome = "Maria da Silva",
            Email = "ms@gmail.com",
            Telefone = "654987"
        } 
    };

    using var sr = StringWriter(path);
    using var csvWriter = new CsvWriter(sr, CultureInfo.InvariantCulture);
    csvWriter.WriteRecords(pessoas);
}



EscreverCsv();

// LerCSVComDynamic();
// LerCsvComClasse();