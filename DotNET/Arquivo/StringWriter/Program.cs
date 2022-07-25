string textReaderText = "TextReader é a classe vase abstrata " +
            "de StreamReader e StringReader, que lê caracteres " +
            "de streams e strings, respectivamente. \n\n" +
            
            "Crie uma instância de TextReader para abrir um arquivo de texto " +
            "para ler um intervalo especificado de caracteres "+
            "ou para cirar um leitora baseado em um fluxo existente. \n\n"+

            "Você também pode usar uma instância de TextReader para ler "+
            "texto de um armazenamento de suporte personalizado usando as mesmas"+
            "APIs que você usaria para uma string ou um fluxo. \n\n";

System.Console.WriteLine($"Texto Original: {textReaderText}");
string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if (linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += '\n';
        break;
    }
}

System.Console.WriteLine($"Texto Modificado: {paragrafo}");
int caractereLido; //O caractere é lido e convertido em um número decimal, que corresponde ao caractere na tabela ASCII
char caractereConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while (true)
{
    caractereLido = sr.Read();
    if (caractereLido == -1) break;

    caractereConvertido = Convert.ToChar(caractereLido);

    if (caractereConvertido == '.')
    {
     sw.Write("\n\n");

     sr.Read(); //Como o proximo caractere a ser lido, se não houvesse os dois sr.Read(), seria '\n\n',   
     sr.Read(); //então é prudente que ler essas duas quebras de linhas e partir para a leitura do proximo caractere.
    }
    else
    {
        sw.Write(caractereConvertido);
    }
}
Console.WriteLine($"Texto Armazenado no StringWrite: {sw.ToString()}");