public class OperacoesLista
{
    public void AdicionarALista(List<string> lista, string item)
    {
        lista.Add(item);
    }
    public void RemoverDaLista(List<string> lista, string item)
    {
        lista.Remove(item);
    }
    public void ImprimirListaString(List<string> lista)
    {
        foreach (var item in lista)
        {
            System.Console.WriteLine(item);
        }
    }
}