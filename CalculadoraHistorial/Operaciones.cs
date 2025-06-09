namespace operaciones;

public class Operacion
{
    private double resultadoAnterior; //Almacena el resultado previo al calculo actual

    private double nuevoValor;// El valor  con el que se opera sobre el resultadoAnterior

    private TipoOperacion operacion; // El tipo de operacion realizada

    public double Resultado
    {
        /*logica del resultado */
    }

    //propiedad para acceder al nuevo valor utlizado

    public double nuevoValor
    {

    }
    public double NuevoValor { get => this.nuevoValor; set => this.nuevoValor = value; }
    public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
    public TipoOperacion Operacion { get => operacion; set => operacion = value; }

    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar //Representa la accion de borrar el resultado actual o el historial
    }
}    