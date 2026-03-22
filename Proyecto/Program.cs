int opcion;
int tipo;
double duracion;
int clasificación;
int hora;
int nivelProduc;
do
{
    menu();
    switch (opcion)
    {
        case 1:
            evaluarContenido();
        break;

        case 2:

        break;

        case 3:

        break;

        case 4:

        break;

        case 5:
            Console.WriteLine("Saliendo. a continuación resumen de los datos:");
        break;

        default:
            Console.WriteLine("Opción no válida");
        break;
    }
}while (opcion != 5);




void menu()
{
    Console.WriteLine("Bienvenido al menu de streaming");
    Console.WriteLine("1. Evaluar contenido");
    Console.WriteLine("2. Mostrar reglas");
    Console.WriteLine("3. Mostrar estadísticas de la sesión");
    Console.WriteLine("4. Reiniciar estadísticas");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elija una opción para continuar");
    if(int.TryParse(Console.ReadLine(), out opcion))
    {

    }
    else
    {
        Console.WriteLine("Ingrese un numero correspondiente a las opciones");
    }
}
void evaluarContenido()
{
    tipoContenido();
    
}
int tipoContenido()
{
    Console.WriteLine("Ingrese el tipo de contenido");
    Console.WriteLine("1. Pelicula");
    Console.WriteLine("2. Serie");
    Console.WriteLine("3. Documental");
    Console.WriteLine("4. Evento en vivo");
    if(int.TryParse(Console.ReadLine(), out tipo))
    {
        return tipo;
    }
    else
    {
        Console.WriteLine("El dato ingresado no es valido");
        return tipo = 0;
    }
}