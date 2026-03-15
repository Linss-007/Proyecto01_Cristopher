int opcion;
do
{
    menu();
    switch (opcion)
    {
        case 1:

        break;

        case 2:

        break;

        case 3:

        break;

        case 4:

        break;

        case 5:
            Console.WriteLine("Saliendo...");
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
    opcion = int.Parse(Console.ReadLine());
}