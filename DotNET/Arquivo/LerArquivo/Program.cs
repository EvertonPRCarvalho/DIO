using System.IO;

static void LerAquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var arq in arquivos)
    {
        var fileInfo = new FileInfo(arq);
        System.Console.WriteLine($"[Nome]: {fileInfo.Name}");
        System.Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
        System.Console.WriteLine($"[Ultimo acesso]: {fileInfo.LastAccessTime}");
        System.Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");
        System.Console.WriteLine("====================");
    }
}

LerAquivos("../Arquivo/Globo");