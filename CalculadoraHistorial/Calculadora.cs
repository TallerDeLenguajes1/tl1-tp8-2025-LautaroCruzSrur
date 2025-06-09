namespace EspacioCalculadora;

using operaciones;

public class Calculadora
{

     private List<Operacion> historial = new List<Operacion>();

    private double dato;

    public Calculadora(double valorInicial)
    {
        dato = valorInicial;
    }

    public void Sumar(double termino)
    {
        dato += termino;
    }
    public void Restar(double termino)
    {
        dato -= termino;
    }
    public void Dividir(double termino)
    {
        if (termino != 0) dato /= termino;

    }
    public void Multiplicar(double termino)
    {
        dato *= termino;
    }
    public double Resultado()
    {
        return dato;
    }

}

