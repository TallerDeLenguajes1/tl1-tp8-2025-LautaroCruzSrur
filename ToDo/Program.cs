using TareaTodo;


//Como hago un archivo para funciones
void MostrarTareas(List<Tarea> tareas)
{
    foreach (Tarea tarea in tareas)
    {
        Console.WriteLine(tarea.Duracion + " - " + tarea.Descripcion + "-" + tarea.Estado);
    }
}
void MoverTarea(List<Tarea> pendientes, List<Tarea> realizadas)
{
    Console.WriteLine("\nIngrese el id de la tarea");
    int id;
    if (!int.TryParse(Console.ReadLine(), out id))
{
    Console.WriteLine("\nOpción inválida.");
    return;
}
    Tarea? tareaAMover = pendientes.Find(t => t.TareaID == id);
    if (tareaAMover != null)
    {
        tareaAMover.Estado = Tarea.EstadoTarea.Realizada;
        realizadas.Add(tareaAMover);
        pendientes.Remove(tareaAMover);
    }
    else
    {
         Console.WriteLine("No se encontró una tarea con ese ID.");
    }
}
void BuscarTarea(List<Tarea> lista)
{
    Console.Write("Ingrese la descripción de la tarea: ");
    string descripcion = Console.ReadLine() ?? "";


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



List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas =  new List<Tarea>();
Random random = new Random();
string salida = "";
    int i = 0;
    do
    {

        int numeroAleatorio = random.Next(10, 1001);
        int id = generadorID.ObtenerID();
        string descripcion = $"Esta es la tarea con el id  {id}";
        Tarea unaTarea = new Tarea(id, descripcion, numeroAleatorio, 0);
        i++;
        TareasPendientes.Add(unaTarea);

        Console.WriteLine("\n¿Desea ingresar una nueva tarea? (s/n)");
        salida = Console.ReadLine() ?? "";
    } while (salida != "n");
salida = "";
do
{
    Console.WriteLine("\n--------MENU----------");
    Console.WriteLine("\n Precione 1 para Mover las Tareas Pendientes a realizadas");
    Console.WriteLine("\n Precione 2 para Buscar Tarea");
    Console.WriteLine("\n Precione 3 para Mostrar Tareas");
    int opcion;
if (!int.TryParse(Console.ReadLine(), out opcion))
{
    Console.WriteLine("Opción inválida.");
    return;
}
    switch (opcion)
    {
        case 1:
            MostrarTareas(TareasPendientes);
            MoverTarea(TareasPendientes, TareasRealizadas);
            break;
        case 2:
            BuscarTarea(TareasPendientes);
            break;
        case 3:
            MostrarTareas(TareasPendientes);
            MostrarTareas(TareasRealizadas);
            break;
    }
    Console.WriteLine("\n¿Desea salir? (s/n)");
    salida = Console.ReadLine() ?? "";

} while (salida != "s");


