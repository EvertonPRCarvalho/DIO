using Arquivos.Helper;
using System.Collections.Generic;

var caminho = "D:/Estudos/DIO/Bootcamp Unimed/project-flexbox-dio/flex-projeto/CSharp/Arquivos/Pasta_Teste_2/arquivo-teste.txt";

//var destino = "D:/Estudos/DIO/Bootcamp Unimed/project-flexbox-dio/flex-projeto/CSharp/Arquivos/Pasta_Teste_2/arquivo-teste.txt";
var destinobk = "D:/Estudos/DIO/Bootcamp Unimed/project-flexbox-dio/flex-projeto/CSharp/Arquivos/Pasta_Teste_2/arquivo-teste-bk.txt";
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var listaString = new List<string>{"Linha 4", "Linha 5", "Linha 6",};

//string conteudo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. \n It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";


FileHelper helper = new FileHelper();
//helper.CriarDiretorio(Path.Combine(caminho, "Subpasta_Teste_C_D_1", "Subpasta_Teste_C_D_2"));
//helper.ApagarDiretorio(caminho, true);

//helper.ListarDirArquivos(caminho);
//helper.ListarDiretorios(caminho);

//helper.MoverArquivo(caminho, destino, false);
//helper.CopiarArquivo(caminho, destinobk, false);
//helper.CriarArquivoTexto(caminhoArquivo, conteudo);
//helper.AdicionarTextoo(caminho, conteudo);
//helper.LerAquivo(caminho);
helper.DeletarArquivo(caminho);

//helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
//helper.AdicionarTextoStream(caminhoArquivo, listaString);
//helper.LerAquivoStream(caminho);