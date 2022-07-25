public class OperacoesFila
{
    public void AdicionarAFila(Queue<string> lista, string nome)
    {
        lista.Enqueue(nome);
    }
    public void SistemaDeGerenciamentoFila(Queue<string> fila)
    {
        System.Console.WriteLine($"Total de pessoas na fila: {fila.Count}");

        while (fila.Count > 0)
        {
            System.Console.WriteLine($"Vez de: {fila.Peek()}");
            System.Console.WriteLine($"{fila.Dequeue()} ATENDIDO!");
        }
    }
}