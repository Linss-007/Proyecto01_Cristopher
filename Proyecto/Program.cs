int opcion;
int tipo = 0;
double duracion = 0;
int clasificación = 0;
int hora = -1;
int nivelProduc = 0;
int errores = 0;
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
    switch(tipo)
    {
        case 1:
            duracionContenido();
            clasContenido();
            horaContenido();
            producContenido();
            if(clasificación == 2 && (hora < 6 || hora > 22))
            {
                Console.WriteLine("Hay un error la hora ingresada no se puede aplicar a la clasificación +13");
                errores++;
            }
            else if(clasificación == 3 && (hora < 5 || hora > 22))
            {
                Console.WriteLine("Hay un error la hora ingresada no se puede aplicar a la clasificación +18");
                errores++;
            }

            if(duracion < 60 || duracion > 180)
            {
                Console.WriteLine("La duración de la ingresada no corresponde a la categoria película");
                errores++;
            }

            if (nivelProduc == 3 && clasificación == 3)
            {
                Console.WriteLine("El nivel de producción bajo no permite la clasificación +18");
                errores++;
            }
            limpiar();
        break;

        case 2:
            duracionContenido();
            clasContenido();
            horaContenido();
            producContenido();
            if (clasificación == 2 && (hora < 6 || hora > 22))
            {
                Console.WriteLine("Hay un error la hora ingresada no se puede aplicar a la clasificación +13");
                errores++;
            }
            else if (clasificación == 3 && (hora < 5 || hora > 22))
            {
                Console.WriteLine("Hay un error la hora ingresada no se puede aplicar a la clasificación +18");
                errores++;
            }

            if (duracion < 20 || duracion > 90)
            {
                Console.WriteLine("La duración de la ingresada no corresponde a la categoria película");
                errores++;
            }

            if (nivelProduc == 3 && clasificación == 3)
            {
                Console.WriteLine("El nivel de producción bajo no permite la clasificación +18");
                errores++;
            }
            limpiar();
        break;

        case 3:
            duracionContenido();
            clasContenido();
            horaContenido();
            producContenido();
            if (clasificación == 2 && (hora < 6 || hora > 22))
            {
                Console.WriteLine("Hay un error la hora ingresada no se puede aplicar a la clasificación +13");
                errores++;
            }
            else if (clasificación == 3 && (hora < 5 || hora > 22))
            {
                Console.WriteLine("Hay un error la hora ingresada no se puede aplicar a la clasificación +18");
                errores++;
            }

            if (duracion < 30 || duracion > 120)
            {
                Console.WriteLine("La duración de la ingresada no corresponde a la categoria película");
                errores++;
            }

            if (nivelProduc == 3 && clasificación == 3)
            {
                Console.WriteLine("El nivel de producción bajo no permite la clasificación +18");
                errores++;
            }
            limpiar();
        break;

        case 4:
            duracionContenido();
            clasContenido();
            horaContenido();
            producContenido();
            if (clasificación == 2 && (hora < 6 || hora > 22))
            {
                Console.WriteLine("Hay un error la hora ingresada no se puede aplicar a la clasificación +13");
                errores++;
            }
            else if (clasificación == 3 && (hora < 5 || hora > 22))
            {
                Console.WriteLine("Hay un error la hora ingresada no se puede aplicar a la clasificación +18");
                errores++;
            }

            if (duracion < 30 || duracion > 240)
            {
                Console.WriteLine("La duración de la ingresada no corresponde a la categoria película");
                errores++;
            }

            if (nivelProduc == 3 && clasificación == 3)
            {
                Console.WriteLine("El nivel de producción bajo no permite la clasificación +18");
                errores++;
            }
            limpiar();
        break;

        default:
            Console.WriteLine("Tipo no existente");
        break;
    }
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
    Console.WriteLine("Ingrese la duración del contenido en minutos (de 20 a 240 min)");
    while (!datoCorrecto || duracion < 20 || duracion > 240)
    {
        datoCorrecto = double.TryParse(Console.ReadLine(), out duracion);
        if (!datoCorrecto)
        {
            Console.WriteLine("Dato incorrecto vuelva a ingresarlo");
        }
        else if (duracion < 20 || duracion > 240)
        {
            Console.WriteLine("Duración fuera de rango");
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
    while(!datoCorrecto || (clasificación != 1 && clasificación != 2 && clasificación != 3))
    {
        datoCorrecto = int.TryParse(Console.ReadLine(), out clasificación);
        if(!datoCorrecto)
        {
            Console.WriteLine("Clasificación no valida, intente de nuevo");
        }
        else if (clasificación != 1 && clasificación != 2 && clasificación != 3)
        {
            Console.WriteLine("La opción ingresada no existe, intente de nuevo");
        }
    }
    return clasificación;
}
int horaContenido()
{
    bool datoCorrecto = false;
    Console.WriteLine("Ingrese la hora programada (formato 24 horas)");
    while(!datoCorrecto || hora < 0 || hora > 23)
    {
        datoCorrecto = int.TryParse(Console.ReadLine(), out hora);
        if(!datoCorrecto)
        {
            Console.WriteLine("Hora no válida, intente de nuevo");
        }
        else if (hora < 0 || hora > 23)
        {
            Console.WriteLine("La hora no es válida");
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
        if (!datoCorrecto || (nivelProduc != 1 && nivelProduc != 2 && nivelProduc != 3))
        {
            Console.WriteLine("Nivel no válido, intente de nuevo");
        }
        else if (nivelProduc != 1 && nivelProduc != 2 && nivelProduc != 3)
        {
            Console.WriteLine("La opción elejida no es válida, intente de nuevo");
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