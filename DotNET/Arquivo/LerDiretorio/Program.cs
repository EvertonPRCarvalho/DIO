using System.IO;
static void LerDeiretorios(string path)
{
    var diretorios = Directory.GetDirectories(path,"*",SearchOption.AllDirectories);
    foreach (var dir in diretorios)
    {
        var dirInfo = new DirectoryInfo(dir);
        System.Console.WriteLine($"[NOME]: {dirInfo.Name}");
        System.Console.WriteLine($"[Raiz]: {dirInfo.Root}");
        if (dirInfo.Parent != null)
            System.Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");
        System.Console.WriteLine("===========");
    }
}

LerDeiretorios("../Arquivo/Globo");