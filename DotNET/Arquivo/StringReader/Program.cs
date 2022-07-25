using System.Text;

var sb = new StringBuilder();

sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("e na segunda linha");
sb.AppendLine("e o final");

using var sr = new StringReader(sb.ToString());
var buffer = new char[10];
var tamanho = 0;
do 
{
    buffer = new char[10];
    tamanho = sr.Read(buffer);
    Console.WriteLine(string.Join("", buffer));
}while(tamanho >= buffer.Length);

System.Console.WriteLine("Digite [ENTER] para finalizar");
Console.ReadKey();