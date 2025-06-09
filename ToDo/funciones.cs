using TareaTodo;

namespace funciones;

//using TareaTodo;

void MostrarTareas(List<Tarea> tareas)
{
    foreach (Tarea tarea in tareas)
    {
        Console.WriteLine(tarea.Duracion + " - " + tarea.Descripcion + "-" + tarea.Estado);
    }
}
void Menu(List<Tarea> pendientes, List<Tarea> realizadas)
{
    Console.WriteLine("Precione 1 para Mover las Tareas Pendientes a realizadas");
    MostrarTareas(TareasPendientes);

}
void MoverTarea(List<Tarea> pendientes, List<Tarea> realizadas)
{
    int id = Console.Read();
    Tarea? tareaAMover = pendientes.Find(t => t.TareaID == id);
    if (tareaAMover != null)
    {
        realizadas.Add(tareaAMover);
        pendientes.Remove(tareaAMover);
    }
}

void BuscarTarea(string descripcion, List<Tarea> lista)
{
    Tarea? tareaABuscar = lista.Find(t => t.Descripcion == descripcion);

    if (tareaABuscar != null)
    {
        Console.WriteLine(tareaABuscar.Duracion + " - " + tareaABuscar.Descripcion + " - " + tareaABuscar.Estado);
    }
    else
    {
        Console.WriteLine("No se encontró ninguna tarea con esa descripción.");
    }
}


