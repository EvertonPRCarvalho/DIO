using Series.Classes;
using Series.Enum;

internal class Program
{
    static SerieRepositorio repositorio = new SerieRepositorio();
    private static void Main(string[] args)
    {
        string opcaoUsuario = string.Empty;
        while (opcaoUsuario.ToUpper() != "X")
        {
            opcaoUsuario = ObterOpcaoUsuario();
            switch (opcaoUsuario)
            {
                case "1":
                    ListarSeries();
                    break;
                case "2":
                    InserirSerie();
                    break;
                case "3":
                    AtualizarSeries();
                    break;
                case "4":
                    ExcluirSeries();
                    break;
                case "5":
                    VisualizarSeries();
                    break;
                case "C":
                    Console.Clear();
                    break;
                default:
                throw new ArgumentOutOfRangeException();
            }
        }


    }
    private static void ListarSeries()
    {
        var lista = repositorio.Lista();
        
        if (lista.Count == 0)
        {
            System.Console.WriteLine("Nenhuma série cadastrada.");
            return;
        }

        foreach (var serie in lista)
        {
            System.Console.WriteLine($"ID {serie.retornaId()}: {serie.retornaTitulo()}");
        }
    }
    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("DIO Séries a seu dispor!");
        Console.WriteLine("Informe a opção desegada:");

        Console.WriteLine("1- Listar séries");
        Console.WriteLine("2- Inserir nova série");
        Console.WriteLine("3- Atualizar série");
        Console.WriteLine("4- Excluir série");
        Console.WriteLine("5- Visualizar série");
        Console.WriteLine("C- Limpar Tela");
        Console.WriteLine("X- Sair");
        Console.WriteLine();

        string? opcaoUsuario = Console.ReadLine();
        Console.WriteLine();
        return opcaoUsuario;
    }
    private static void InserirSerie()
    {
        System.Console.WriteLine("Inserir nova série:");

        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            System.Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
        }
        System.Console.WriteLine("Digite o gênero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o Título da Série: ");
        string? entradaTitulo = Console.ReadLine();
        System.Console.WriteLine("Digite o Ano de Início da Série: ");
        int entradaAno = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite a Descrição da Série");
        string? entradaDescricao = Console.ReadLine();

        Serie novaSerie = new Serie(
            id       : repositorio.ProximoId(),
            genero   : (Genero)entradaGenero,
            titulo   : entradaTitulo,
            descricao: entradaDescricao,
            ano      : entradaAno);
        repositorio.Inserir(novaSerie);
    }
    private static void AtualizarSeries()
    {
        var lista = repositorio.Lista();

        ListarSeries();
        System.Console.WriteLine("Digite o ID da série que deseja ATUALIZAR:");
        int id = int.Parse(Console.ReadLine());
        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            System.Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
        }
     
        foreach (var serie in lista)
        {
            if (serie.retornaId() == id)
            {
                System.Console.WriteLine("Digite o gênero entre as opções acima: ");
                int entrada_Genero = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite o Título da Série: ");
                string? entradaTitulo = Console.ReadLine();
                System.Console.WriteLine("Digite o Ano de Início da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite a Descrição da Série");
                string? entradaDescricao = Console.ReadLine();

                System.Console.WriteLine("Cheguei aqui!");

                Serie serieAtualizada = new Serie(
                    id       : id,
                    genero   : (Genero)entrada_Genero,
                    titulo   : entradaTitulo,
                    descricao: entradaDescricao,
                    ano      : entradaAno
                ); 
                
                System.Console.WriteLine("Cheguei aqui!");
                
                repositorio.Atualizar(id, serieAtualizada);
            }
        }


    }
    private static void ExcluirSeries()
    {
        var lista = repositorio.Lista();

        System.Console.WriteLine("Digite o ID da série que deseja EXCLUIR: ");
        int id = int.Parse(Console.ReadLine());
        foreach (var serie in lista)
        {
            if (serie.RetornaExcluido())
            {
                System.Console.WriteLine("A série já foi excluída.");
            }
            else
            {
                repositorio.Excluir(id);    
                System.Console.WriteLine($"A série {serie.retornaTitulo} foi excluída com sucesso!");
                break;
            }
        }
        repositorio.Excluir(id);
    }
    private static void VisualizarSeries()
    {
        var lista = repositorio.Lista();
        
        if (lista.Count == 0)
        {
            System.Console.WriteLine("Nenhuma série cadastrada.");
            return;
        }

        foreach (var serie in lista)
        {
            System.Console.WriteLine(serie.ToString()+"\n");
        }


    }
}