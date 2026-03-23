int opcion;
int tipo = 0;
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
    bool datoCorrecto = false;
    Console.WriteLine("Ingrese el tipo de contenido");
    Console.WriteLine("1. Pelicula");
    Console.WriteLine("2. Serie");
    Console.WriteLine("3. Documental");
    Console.WriteLine("4. Evento en vivo");
    while(!datoCorrecto)
    {
        datoCorrecto = int.TryParse(Console.ReadLine(), out tipo);
        if(!datoCorrecto)
        {
            Console.WriteLine("Dato no válido, vuelva a ingresarlo");
        }
    }
    return tipo;
}
double duracionContenido()
{
    bool datoCorrecto = false;
    Console.WriteLine("Ingrese la duración del contenido en minutos (ejemplo: 120)");
    while (!datoCorrecto)
    {
        datoCorrecto = double.TryParse(Console.ReadLine(), out duracion);
        if (!datoCorrecto)
        {
            Console.WriteLine("Dato incorrecto vuelva a ingresarlo");
        }
    }
    return duracion;
}
int clasContenido()
{
    bool datoCorrecto = false;
    Console.WriteLine("Ingrese la clasificación del contenido");
    Console.WriteLine("1. Todo público");
    Console.WriteLine("2. +13");
    Console.WriteLine("3. +18");
    while(!datoCorrecto)
    {
        datoCorrecto = int.TryParse(Console.ReadLine(), out clasificación);
        if(!datoCorrecto)
        {
            Console.WriteLine("Clasificación no valida, intente de nuevo");
        }
    }
    return clasificación;
}
int horaContenido()
{
    bool datoCorrecto = false;
    Console.WriteLine("Ingrese la hora programada (formato 24 horas)");
    while(!datoCorrecto)
    {
        datoCorrecto = int.TryParse(Console.ReadLine(), out hora);
        if(!datoCorrecto)
        {
            Console.WriteLine("Hora no válida, intente de nuevo");
        }
    }
    return hora;
}
int producContenido()
{
    bool datoCorrecto = false;
    Console.WriteLine("Ingrese el nivel de producción");
    Console.WriteLine("1. Alto");
    Console.WriteLine("2. Medio");
    Console.WriteLine("3. Bajo");
    while(!datoCorrecto)
    {
        datoCorrecto = int.TryParse(Console.ReadLine(), out nivelProduc);
        if(!datoCorrecto)
        {
            Console.WriteLine("Nivel no válido, intente de nuevo");
        }
    }
    return nivelProduc;
}
void limpiar()
{
    Console.WriteLine("Pulse cualquier tecla para continuar");
    Console.ReadKey();
    Console.Clear();
}