internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[4,2]
        {
            {8, 8},
            {3, 6},
            {1, 5},
            {7, 9},
        };

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
           for (int j = 0; j < matriz.GetLength(1); j++)
           {
                Console.WriteLine($"Linha {i}, Coluna {j}: Valor: {matriz[i,j]}");
           }
        }
        // int[] arrayInteiros = new int[3];

        // arrayInteiros[0] = 10;
        // arrayInteiros[1] = 20;
        // arrayInteiros[2] = 30;

        // Console.WriteLine("FOR");
        // for (int i = 0; i < arrayInteiros.Length; i++)
        // {
        //     Console.WriteLine(arrayInteiros[i]);
        // }

        // Console.WriteLine("FOREACHE");
        // foreach (int item in arrayInteiros)
        // {
            
        //     Console.WriteLine(item); /*cw + Tab*/
        // }
        Console.WriteLine("Matriz");
    }
}