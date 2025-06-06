using TareaTodo;

 Random random = new Random();
int numeroAleatorio = random.Next(10, 1001);
int id = generadorID.ObtenerID();
string descripcion = $"Esta es la tarea con id {id}";

Tarea unaTarea = new Tarea(id, descripcion, numeroAleatorio);

Console.WriteLine($"\nLa tarea id{unaTarea.TareaID}, descripcion {unaTarea.Descripcion}, duracion {unaTarea.Duracion}");
List<Tarea> TareasPendientes = [];
List<Tarea> TareasRealizadas = [];
