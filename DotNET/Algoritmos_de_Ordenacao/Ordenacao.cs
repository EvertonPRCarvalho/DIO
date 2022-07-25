public class Ordenacao
{
    public void BubbleSort(ref int[] array)
    {

        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < (array.Length - 1); j++)
            {
                if (array[j] > array[j+1])
                {
                    temp = array[j+1];
                    array[j+1] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
    public void Imprimir(int[] array)
    {
        string paraImprimir ="";
        for (int i = 0; i < array.Length; i++)
        {   
            paraImprimir += " | " + array[i];
        }
        System.Console.WriteLine(paraImprimir);
    }
    
    public void Ordenar(ref int[] array)
    {
        Array.Sort(array);
    }

    public void Copiar(ref int[] array, ref int[] arrayDestino)
    {
        Array.Copy(array, arrayDestino, array.Length);
    }

    public bool Existe (int[] array, int valor)
    {
        return Array.Exists(array, elemento => elemento == valor);
    }

    public bool TodosMaioQue(int[] array, int valor)
    {
        return Array.TrueForAll(array, elemento => elemento > valor);
    }

    public void RedimensionarArray(ref int[] array, int novoTamanho)
    {
        Array.Resize(ref array, novoTamanho);
    }
    public string[] ConverterParaArrayString(int[] array)
    {
        return Array.ConvertAll(array, elemento => elemento.ToString());
    }
}