// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

int opcion = 0;
bool continuar = true;

Calculadora op = new Calculadora();

while (continuar)
{
    Console.WriteLine($"Resultado actual: " + op.Dato);
    Console.WriteLine("------Calculadora------");
    Console.WriteLine("1_ Suma");
    Console.WriteLine("2_ Resta");
    Console.WriteLine("3_ Multiplicación");
    Console.WriteLine("4_ División");
    Console.WriteLine("5_ Limpiar");
    Console.WriteLine("6_ Historial");
    Console.WriteLine("7_ Salir");
    Console.WriteLine("----------------------------");
    Console.Write("Ingrese la opción: ");
    opcion = Console.Read();
    Console.ReadLine();
    opcion -= '0';

    switch (opcion)
    {
        case 1:
            op.suma(pedirValor("Ingresar valor a sumar"));
            break;
        case 2:
            op.resta(pedirValor("Ingresar valor a restar"));
            break;
        case 3:
            op.multiplicacion(pedirValor("Ingresar valor a multiplicar"));
            break;
        case 4:
            op.division(pedirValor("Ingresar valor distinto de 0 a dividir"));
            break;
        case 5:
            op.limpiar();
            break;
        case 6:
            mostrarHistorial(op);
            break;
        case 7:
            Console.WriteLine("Saliendo.......");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
}




double pedirValor(string mensaje)
{
    double Valor;
    Console.WriteLine(mensaje);
    while (!double.TryParse(Console.ReadLine(), out Valor))
    {
        Console.WriteLine("Error, ingrese un valor correcto");
    }
    return Valor;
}

void mostrarHistorial(Calculadora calc)
{
    Console.WriteLine("====Historial====");
    int i = 1;
    foreach (var item in calc.Historial)
    {
        Console.WriteLine($"{i++} Operacion: {item.Ope} - Resultado: {item.Resultado}");
    }
}