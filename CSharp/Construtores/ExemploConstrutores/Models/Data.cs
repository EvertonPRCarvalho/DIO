namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;

        public int Mes { get => mes; set => mes = value; }
        public bool ValidaMes(int mes)
        {
            if (mes > 0 && mes <= 12) return true;
            else return false;
        }
        public void RegistrarMes(int mes)
        {
            if (ValidaMes(mes))
            {
                this.Mes = mes;
                System.Console.WriteLine("ÊXITO! Mês registrado com sucesso.");
            }
            else
            {
                System.Console.WriteLine("ERRO: Mês inválido! Insira valores entre 1 e 12 correspondente ao mês desejado.");
            }
        }    
    }
}