using TareaTodo;

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas =  new List<Tarea>();
Random random = new Random();

string salida = "";
int i = 0;
do
{

    int numeroAleatorio = random.Next(10, 1001);
    int id = generadorID.ObtenerID();
    string descripcion = $"Esta es la tarea con numero {id}";
    Tarea unaTarea = new Tarea(id, descripcion, numeroAleatorio , 0);
    i++;
    TareasPendientes.Add(unaTarea);

    Console.WriteLine("\n¿Desea ingresar una nueva tarea? (s/n)");
    salida = Console.ReadLine();

} while (salida != "n");
