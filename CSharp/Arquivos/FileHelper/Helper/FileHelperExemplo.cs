using System.IO;
using System.Collections.Generic;

namespace Arquivos.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            //"*", SearchOption.AllDirectories esses parâmetros retornarão todoas as subpastas existentes. Caso eles não sejam passados, há apenas o retorno das pastas mais externas.
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }    

        public void ListarDirArquivos(string caminho)
        {
            var retornoCaminhoArq = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
            //Caso o objetivo fosse retornar arquivos txt bastaria trocar o parâmetro "*" por "*.txt"
            //Similarmente, caso o objetivo fosse retornar arquivos com o prefixo conta bastaria trocar "*" por "conta*"
            System.Console.WriteLine("====================================================");
            System.Console.WriteLine("====================================================");
            foreach (var retorno in retornoCaminhoArq)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            //O using libera o arquivo em memória assim que esse processo for finalizado
            using(var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                    //É feita a escrita na stream e a stream escreve no arquivo.
                }
            }
        }
        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            //O using libera o arquivo em memória assim que esse processo for finalizado
            using(var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                    //É feita a escrita na stream e a stream escreve no arquivo.
                }
            }
        }

        public void AdicionarTextoo(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void LerAquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerAquivoStream(string caminho)
        {
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }
    
        public void MoverArquivo(string caminho, string destino)
        {
            File.Move(caminho, destino);
        }

        public void ApagarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    
        public void CopiarArquivo(string caminho, string destino, bool sobrescrever)
        {
            File.Copy(caminho, destino, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}