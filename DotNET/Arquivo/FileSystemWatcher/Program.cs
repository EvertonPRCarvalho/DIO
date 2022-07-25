using System;
using System.IO;

var path = "../Arquivo/Globo";
using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;


System.Console.WriteLine($"Monitorando eventos na pasta {path}");
System.Console.WriteLine("Pressione [enter] para finalizar...");
System.Console.ReadLine();
void OnCreated (object sender, FileSystemEventArgs e)
{
    System.Console.WriteLine($"Foi criado o arquivo {e.Name}");
}
void OnDeleted(object sender, FileSystemEventArgs e)
{
    System.Console.WriteLine($"Foi deletado o arquivo {e.Name}");
}
void OnRenamed(object sender, FileSystemEventArgs e)
{
    System.Console.WriteLine($"O arquivo {e.Name} foi renomeado para {e.Name}");
}