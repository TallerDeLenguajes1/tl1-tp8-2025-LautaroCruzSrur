namespace TareaTodo;

public class Tarea
{
    public enum EstadoTarea
    {
        Pendiente = 0,
        Realizada = 1
    }

    private int tareaID;
    private string? descripcion;
    private int duracion;

    EstadoTarea estado;

    public int TareaID { get => tareaID; set => tareaID = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion
    {
        get => duracion; set => duracion = value;
    }
    public EstadoTarea Estado { get => estado; set => estado = value; }

    public Tarea(int tareaID, string descripcion, int duracion, EstadoTarea estado)
    {
        this.tareaID = tareaID;
        this.descripcion = descripcion;
        this.duracion = duracion;
        this.estado = estado;
    }
}

public class generadorID
{
    public static int id = 1000;

    public static int ObtenerID()
    {
        return id++;
    }
}
public class Ramdom;


