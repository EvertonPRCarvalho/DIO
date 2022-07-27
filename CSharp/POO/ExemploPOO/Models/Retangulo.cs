public class Retangulo
{
    private double comprimento;
    private double largura;

    public bool ValoresPositivos(double comprimento, double largura)
    {
       if (comprimento > 0 && largura > 0) return true;
       else return false;
    }
    public void DefinirMedidas(double comprimento, double largura)
    {   
        this.comprimento = comprimento;
        this.largura = largura;        
    }

    public double ObterArea()
    { 
        return comprimento * largura;
    }
}
