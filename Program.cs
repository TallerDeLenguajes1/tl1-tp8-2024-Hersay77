using RecursosParaManejarTareas;

//1. Cree aleatoriamente N tareas pendientes.
Random random = new Random(); //nueva instancia de objeto random
int N = random.Next(1, 10); //variable con numero random a partir de objeto random, establece numero de tareas aleatorias

var TareasPendientes = new List<Tarea>(); //decalaraicon lista de tareas pendientes
var TareasRealizadas = new List<Tarea>(); //declaracion lista de tareas realizadas

for (int i = 0; i < N; i++)
{
    TareasPendientes.Add(new Tarea(){ 
        Id = i,
        Descripcion = "Tarea " + i,
        Duracion = random.Next(10, 100) 
    });
}

//2. Desarrolle una interfaz para mover las tareas pendientes a realizadas.
//3. Desarrolle una interfaz para buscar tareas pendientes por descripción.


int opcion;
do
{
    Console.WriteLine("##############################################");
    Console.WriteLine("#                   MENU                     #");
    Console.WriteLine("##############################################");
    Console.WriteLine("# 1 - MOSTRAR LISTAS DE TAREAS               #");
    Console.WriteLine("# 2 - MOVER TAREA PENDIENTE A REALIZADAS     #");
    Console.WriteLine("# 3 - BUSCAR TAREA PENDIENTE POR DESCRIPCION #");
    Console.WriteLine("# 4 - AGREGAR UNA TAREA PENDIENTE            #");
    Console.WriteLine("# 5 - ELIMINAR UNA TAREA PENDIENTE           #");
    Console.WriteLine("# 6 - SALIR                                  #");
    Console.WriteLine("##############################################");
    Console.WriteLine("INGRESE UNA OPCION: ");
    if (int.TryParse(Console.ReadLine(), out opcion) && opcion > 0 && opcion <= 6)
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("#### MOSTRANDO LISTAS DE TAREAS ####");
                Console.WriteLine("#### TAREAS PENDIENTES #### ");
                if (TareasPendientes.Count == 0)
                {
                    Console.WriteLine("Lista Vacia");
                }
                else
                {
                    foreach (var tarea in TareasPendientes)
                    {   
                        Console.WriteLine(tarea.ShowTarea());
                    }
                }

                Console.WriteLine("#### TAREAS REALZIADAS #### ");
                if (TareasRealizadas.Count == 0)
                {
                    Console.WriteLine("Lista Vacia");
                }
                else
                {
                    foreach (var tarea in TareasRealizadas)
                    {   
                        Console.WriteLine(tarea.ShowTarea());
                    }
                }
                Console.WriteLine("\n");

            break;
            case 2:
                int idABuscar;
                Console.WriteLine("Ingrese id de Tarea: ");
                if (int.TryParse(Console.ReadLine(), out idABuscar))
                {
                    Tarea tareaEncontrada = TareasPendientes.Find(t => t.Id == idABuscar); //uso metodo Find proporcionado por List<t>, devuelve el tipo t, enste caso Tarea si se cumple tarea => tarea.Id = idAbuscar sino devuelve null
                    if (tareaEncontrada != null)
                    {
                        TareasRealizadas.Add(tareaEncontrada); //agreo a realizadas
                        TareasPendientes.Remove(tareaEncontrada); //elimino de pendientes
                        Console.WriteLine("Se movio la tarea" + tareaEncontrada.ShowTarea());
                    }
                    else
                    {
                        Console.WriteLine("Tarea no encontrada");
                    }
                }
                else
                {
                    Console.WriteLine("Ingreso incorrecto");
                }
            break;
            case 3:
                Console.WriteLine("Ingrese descripcion de Tarea: ");
                string descripciónABuscar = Console.ReadLine();
                Tarea tareaMismaDescripcion = TareasPendientes.Find(t => t.Descripcion == descripciónABuscar); //uso metodo Find proporcionado por List<t>, devuelve el tipo t, enste caso Tarea si se cumple tareaMismaDescripcion en descripcion
                if (tareaMismaDescripcion != null)
                {
                    Console.WriteLine("Tarea encontrada: " + tareaMismaDescripcion.ShowTarea());
                }
                else
                {
                    Console.WriteLine("Tarea no encontrada");
                }
            break;
            case 4:
                Console.WriteLine("Ingresar Descripcion de Tarea: ");
                string descripcionNueva = Console.ReadLine();
                int duracionNueva;
                bool resultado;
                do
                {
                    Console.WriteLine("Ingresar Duracion de Tarea: ");
                    resultado = int.TryParse(Console.ReadLine(), out duracionNueva);
                    if (!resultado)
                    {
                        Console.WriteLine("Ingreso de duracion incorrecto, ingrese un numero entero");
                    }
                } while (!resultado);

                Tarea tareaNueva = new Tarea(TareasPendientes.Count, descripcionNueva, duracionNueva);
                TareasPendientes.Add(tareaNueva);
                Console.WriteLine("Se agrego nueva Tarea");
            break;
            case 5:
                int idAEliminar;
                Console.WriteLine("Ingrese id de Tarea: ");
                if (int.TryParse(Console.ReadLine(), out idAEliminar))
                {
                    Tarea tareaEncontradaEliminar = TareasPendientes.Find(t => t.Id == idAEliminar); //uso metodo Find proporcionado por List<t>, devuelve el tipo t, enste caso Tarea si se cumple tarea => tarea.Id = idAbuscar sino devuelve null
                    if (tareaEncontradaEliminar != null)
                    {
                        TareasPendientes.Remove(tareaEncontradaEliminar); //elimino de pendientes
                        Console.WriteLine("Se Elimino la Tarea" + tareaEncontradaEliminar.ShowTarea());
                    }
                    else
                    {
                        Console.WriteLine("Tarea no encontrada");
                    }
                }
                else
                {
                    Console.WriteLine("Ingreso incorrecto");
                }
            break;
            case 6:
                Console.WriteLine("NOS VEMOS");
            break;

            default:
            break;
        }
    }
    else
    {
        Console.WriteLine("Opcion Incorrecta vuelva a ingresar");
    }
} while (opcion != 6);

//EJERCICIO 2 - EN BRANCH EJERCICIO - 2

