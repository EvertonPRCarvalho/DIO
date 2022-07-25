// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
/*ARQUIVOS*/
var nome = "everton/Peirera";
nome = ValidarNome(nome);
var path = $"{nome}.txt";

static string ValidarNome(string nome)
{
    foreach (var item in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(item, '_');
    }
    return nome;
}
static void CriarArquivo(string path, string texto)
{
    //Formas de se criar arquivos
    //var pathUm = Environment.CurrentDirectory + "./Archives/testeUm.txt";
    //var pathDois = Path.Combine(Environment.CurrentDirectory, "./Archives/testeDois.txt");
    //File.Create(pathUm);
    //File.Create(pathDois);
    //Escrita no arquivo
    try
    {
        StreamWriter stringWrite = new StreamWriter("./Archives/"+path);
        stringWrite.WriteLine(texto);
        stringWrite.Close();
        
    }
    catch 
    {
        throw;
    }
    //stringWrite.Flush(); //Só após a execução do Flush() que realizada a escrita no arquivo.
}
CriarArquivo(path, "Olá! Isso é você.");

/*DIRETÓRIO*/

static void VerificarEMover(string pathOrigem, string pathDestino)
{
    try
    {
        File.Move(pathOrigem,pathDestino);
    }
    catch (FileNotFoundException e)
    {
        System.Console.WriteLine($"Arquivo não encontrado: {e}");
    }
}
static void  VerificarECriar(string path)
{
    if (Directory.Exists($"./{path}"))
    {
        System.Console.WriteLine($"Um diretório com o nome {path} já existe.");
    }
    else
    {
        CriarDirGlobal();
    }
}

static void CriarDirGlobal()
{
    //StreamWriter stringWrite = new StreamWriter("./Archives/"+path);
    var pathTres = Path.Combine(Environment.CurrentDirectory, "Globo");
    var diretorioGlobo = Directory.CreateDirectory(pathTres);


    var dirAmSul =diretorioGlobo.CreateSubdirectory("America_do_Sul");
    var dirAmCentral =diretorioGlobo.CreateSubdirectory("America_do_Central");
    var dirAmNorte =diretorioGlobo.CreateSubdirectory("America_do_Norte");

    dirAmSul.CreateSubdirectory("Brasil");
    dirAmSul.CreateSubdirectory("Argentina");

    dirAmCentral.CreateSubdirectory("Mexico");
    dirAmCentral.CreateSubdirectory("Costa_Rica");

    dirAmNorte.CreateSubdirectory("Canada");
    dirAmNorte.CreateSubdirectory("USA");
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    VerificarEMover(pathOrigem, pathDestino);
}
VerificarECriar("Globo");

CriarArquivo("brasil_estados.csv","estado - sigla;Acre - AC; Alagoas - AL;Amapá - AP; Amazonas - AM;Bahia - BA; Ceará - CE;Distrito Federal - DF;Espírito Santo - ES; Goiás - GO; Maranhão - MA;Mato Grosso - MT;Mato Grosso do Sul - MS;Minas Gerais - MG;Pará - PA;Paraíba - PB;Paraná - PR;Pernambuco - PE;Piauí - PI;Rio de Janeiro - RJ;Rio Grande do Norte - RN;Rio Grande do Sul - RS;Rondônia - RO;Roraima - RR;Santa Catarina - SC;São Paulo - SP;Sergipe - SE;Tocantins - TO.");

MoverArquivo("./Archives/brasil_estados.csv","./Globo/America_do_Sul/Brasil/brasil_estados.csv");//Há a necessidade de passar além do diretório o nome do arquivo que se deseja mover.