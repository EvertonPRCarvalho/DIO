using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
     
        /*===========================================*/
        /*================Lista Dinâmica=============*/
        /*===========================================*/
        List<string> estados = new List<string>();
        estados.Add("PE");
        estados.Add("PB");
        estados.Add("BA");
        estados.Add("SP");

        estados.Remove("SP");
     
        /*===========================================*/
        /*============Operacoes com Fila=============*/
        /*===========================================*/
        OperacoesFila fila = new OperacoesFila();
        
        /*============================================*/
        /*==========Operacoes com Dicionário==========*/
        /*===========================================*/
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("PE", "Pernambuco");
        dic.Add("PB", "Paraíba");
        dic.Add("BA", "Bahia");

        System.Console.WriteLine($"Dicionário: Chave[PE][Valor]={dic["PE"]}");
        dic["PE"] = "PERNAMBUCO";
        System.Console.WriteLine($"Atualizado Dicionário: Chave[PE][Valor]={dic["PE"]}");
        dic.Remove("PE");
        foreach (KeyValuePair<string,string> item in dic)
        {
            Console.WriteLine($"{item.Key}, {item.Value}");
        }
        /*if(dic.TryGetValue("PE", out string estado))
        {
            System.Console.WriteLine(estado);
        }
        else{
            System.Console.WriteLine("Chave inválida. Estado não encontrado!");
        }*/
        /*============================================*/
        /*=============Operacoes com LINQ=============*/
        /*============================================*/
        int[] arrayNumeros = new int[7] {100,1,5,0,4,8,3};
        var minimo = arrayNumeros.Min();
        var maximo = arrayNumeros.Max();
        var medio = arrayNumeros.Average();
        System.Console.WriteLine($"Minimo: {minimo}\nMáximo: {maximo}\nMédio: {medio}\n");

        var numerosPares =
                from num in arrayNumeros
                where num % 2 == 0
                orderby num
                select num;
        var numerosParess = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
        System.Console.WriteLine("Números pares query: "+ String.Join(", ", numerosPares));



        Ordenacao ord = new Ordenacao();
        int[] array = new int[5] {6,3,8,1,9};
        int[] arrayCopia = new int[10];

        int valorProcurado = -1;
        bool existe = ord.Existe(array, valorProcurado);
        
        if(existe) System.Console.WriteLine("Valor encontrado!");
        else System.Console.WriteLine("Valor não encontrado!");

        System.Console.WriteLine("Array Desordenado");
        ord.Imprimir(array);
        System.Console.WriteLine("Array Ordenado");
        ord.Ordenar(ref array);
        ord.Imprimir(array);
        
        System.Console.WriteLine("Array Sem Cópia");
        ord.Imprimir(arrayCopia);
        System.Console.WriteLine("Array Copiado");
        ord.Copiar(ref array, ref arrayCopia);
        ord.Imprimir(arrayCopia);

        System.Console.WriteLine($"capacidade Atual do Array {array.Length}");
        ord.RedimensionarArray(ref array, array.Length*2);
        System.Console.WriteLine($"capacidade Atual do Array {array.Length}");
    }
    
}