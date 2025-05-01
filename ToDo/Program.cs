// See https://aka.ms/new-console-template for more information
using Modelo_ToDo;
Console.WriteLine("Hello, World!");

bool continuar = true;
Manejo man = new Manejo();
while (continuar)
{
    Console.WriteLine("===== Sistema =====");
    Console.WriteLine("1_ Crear tareas aleatorias");
    Console.WriteLine("2_ Marcar tarea realizada");
    Console.WriteLine("3_ Buscar tarea por descripcion");
    Console.WriteLine("4_ Mostrar listas");
    Console.WriteLine("5_ Salir");
    Console.WriteLine("Elija una opcion: ");
    if (int.TryParse(Console.ReadLine(), out int opcion)) {
        switch(opcion) {
            case 1:
                Console.WriteLine("Ingrese la Cantidad de tareas");
                if (int.TryParse(Console.ReadLine(), out int cant)) {
                    man.crearTareas(cant);
                    Console.WriteLine("Tareas creadas");
                }
                break;
            case 2:
                Console.WriteLine("Ingrese una Id");
                if (int.TryParse(Console.ReadLine(), out int id)) {
                    man.MoverTarea(id);
                }
                break;
            case 3:
                Console.WriteLine("Ingrese la descripcion");
                string text = Console.ReadLine();
                man.bucarPorLetra(text);
                break;
            case 4:
                man.MostrarTodas();
                break;
            case 5:
                Console.WriteLine("Saliendo......");
                continuar = false;
                break;
        }
    }
    Console.WriteLine("=======================================");
}