static double Dividir(int a, int b)
{
    if(b == 0){
        throw new DivideByZeroException();
    }
    return a / b;
}

int a = 100, b = 0;

double resultado = 0;

try{
    resultado = Dividir(a, b);
    System.Console.WriteLine($"{a} dividido por {b} = {resultado}");
}catch(DivideByZeroException e) when (a < 0) //A cláusula WHEN limita a entrada nesse catch para todos os n < 0.
{
    System.Console.WriteLine(e);
}
catch(Exception e){
    System.Console.WriteLine(e.Message);
    throw;
}finally //Semrpe será execuado o FINALLY, havendo ou não excecao.
{
    System.Console.WriteLine("Finalmente a divisão foi executada.");
}

