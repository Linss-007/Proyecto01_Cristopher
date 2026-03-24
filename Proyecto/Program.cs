int opcion;
int tipo = 0;
double duracion = 0;
int clasificación = 0;
int hora = -1;
int nivelProduc = 0;
int errores = 0;
string impacto = "";
int cantImpAlto = 0;
int cantImpMedio = 0;
int cantImpBajo = 0;
int cantPublicado = 0;
int cantRechazado = 0;
int cantRevision = 0;
int totalIngresados = 0;
do
{
    menu();
    switch (opcion)
    {
        case 1:
            errores = 0;
            evaluarContenido();
            if(errores > 1)
            {
                Console.WriteLine("No se puede evaluar impacto, corrija los datos mencionados");
            }
            else
            {
                evaluarImpacto();
                decisionFinal();
            }
            limpiar();
        break;

        case 2:
            reglas();
            limpiar();
        break;

        case 3:
            estadisticas();
            limpiar();
        break;

        case 4:

        break;

        case 5:
            Console.WriteLine("Saliendo. A continuación resumen de la ultima sesión:");
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
void reglas()
{
    Console.WriteLine("Sea bienvenido");
    Console.WriteLine("Este es el listado de reglas:\n");
    Console.WriteLine("Reglas de clasificación y horario.");
    Console.WriteLine("Todo publico: cualquier hora");
    Console.WriteLine("+13: entre 6 y 22 horas");
    Console.WriteLine("+18: entre 5 y 22 horas\n");
    Console.WriteLine("Reglas de duración por tipo.");
    Console.WriteLine("Película: 60 a 180 minutos");
    Console.WriteLine("Serie: 20 a 90 minutos");
    Console.WriteLine("Documental: 30 a 120 minutos");
    Console.WriteLine("Evento en vivo: 30 a 240 minutos\n");
    Console.WriteLine("Reglas de producción.");
    Console.WriteLine("Producción baja, válida solo para todo público o +13");
    Console.WriteLine("Producción medio o alta, válida para cualquier clasificación\n");

    Console.WriteLine("Recordatorios.");
    Console.WriteLine("Ingrese los datos de forma correcta (fuera de rango o texto en lugar de numeros)");
    Console.WriteLine("Trate que los datos del contenido coincidan con las reglas\n");
}
void estadisticas()
{
    Console.WriteLine("Estas son las estadisticas actuales de los contenidos ingresados:\n");
    Console.WriteLine($"Cantidad de publicados: {cantPublicado}");
    Console.WriteLine($"Cantidad de rechazos: {cantRechazado}");
    Console.WriteLine($"Cantidad en revisión: {cantRevision}");
    if(cantImpAlto > cantImpMedio && cantImpAlto > cantImpBajo)
    {
        Console.WriteLine("Impacto predominante: Alto");
    }
    else if(cantImpMedio > cantImpAlto && cantImpMedio > cantImpBajo)
    {
        Console.WriteLine("Impacto predominante: Medio");
    }
    else if(cantImpBajo > cantImpMedio && cantImpBajo > cantImpAlto)
    {
        Console.WriteLine("Impacto predominante: Bajo");
    }
    else
    {
        Console.WriteLine("No hay un impacto predominante");
    }

    if(totalIngresados == 0)
    {
        double porcentajeAprobados = 0;
        Console.WriteLine($"El porcentaje de aprovación es de: {porcentajeAprobados}");
    }
    else
    {
        double porcentajeAprobados = (cantPublicado * 100) / totalIngresados;
        Console.WriteLine($"El porcentaje de aprovación es de: {porcentajeAprobados}");
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
                Console.WriteLine("Hay un error, la hora ingresada no se puede aplicar a la clasificación +13");
                errores++;
            }
            else if(clasificación == 3 && (hora < 5 || hora > 22))
            {
                Console.WriteLine("Hay un error, la hora ingresada no se puede aplicar a la clasificación +18");
                errores++;
            }

            if(duracion < 60 || duracion > 180)
            {
                Console.WriteLine("La duración ingresada no corresponde a la categoria: Película");
                errores++;
            }

            if (nivelProduc == 3 && clasificación == 3)
            {
                Console.WriteLine("El nivel de producción bajo no permite la clasificación +18");
                errores++;
            }
        break;

        case 2:
            duracionContenido();
            clasContenido();
            horaContenido();
            producContenido();
            if (clasificación == 2 && (hora < 6 || hora > 22))
            {
                Console.WriteLine("Hay un error, la hora ingresada no se puede aplicar a la clasificación +13");
                errores++;
            }
            else if (clasificación == 3 && (hora < 5 || hora > 22))
            {
                Console.WriteLine("Hay un error, la hora ingresada no se puede aplicar a la clasificación +18");
                errores++;
            }

            if (duracion < 20 || duracion > 90)
            {
                Console.WriteLine("La duración ingresada no corresponde a la categoria: Serie");
                errores++;
            }

            if (nivelProduc == 3 && clasificación == 3)
            {
                Console.WriteLine("El nivel de producción bajo no permite la clasificación +18");
                errores++;
            }
        break;

        case 3:
            duracionContenido();
            clasContenido();
            horaContenido();
            producContenido();
            if (clasificación == 2 && (hora < 6 || hora > 22))
            {
                Console.WriteLine("Hay un error, la hora ingresada no se puede aplicar a la clasificación +13");
                errores++;
            }
            else if (clasificación == 3 && (hora < 5 || hora > 22))
            {
                Console.WriteLine("Hay un error, la hora ingresada no se puede aplicar a la clasificación +18");
                errores++;
            }

            if (duracion < 30 || duracion > 120)
            {
                Console.WriteLine("La duración ingresada no corresponde a la categoria: Documental");
                errores++;
            }

            if (nivelProduc == 3 && clasificación == 3)
            {
                Console.WriteLine("El nivel de producción bajo no permite la clasificación +18");
                errores++;
            }
        break;

        case 4:
            duracionContenido();
            clasContenido();
            horaContenido();
            producContenido();
            if (clasificación == 2 && (hora < 6 || hora > 22))
            {
                Console.WriteLine("Hay un error, la hora ingresada no se puede aplicar a la clasificación +13");
                errores++;
            }
            else if (clasificación == 3 && (hora < 5 || hora > 22))
            {
                Console.WriteLine("Hay un error, la hora ingresada no se puede aplicar a la clasificación +18");
                errores++;
            }

            if (duracion < 30 || duracion > 240)
            {
                Console.WriteLine("La duración ingresada no corresponde a la categoria: Evento en vivo");
                errores++;
            }

            if (nivelProduc == 3 && clasificación == 3)
            {
                Console.WriteLine("El nivel de producción bajo no permite la clasificación +18");
                errores++;
            }
        break;

        default:
            Console.WriteLine("Tipo no existente");
        break;
    }
}
void evaluarImpacto()
{
    if(nivelProduc == 1 || duracion > 120 || (hora > 20 &&  hora < 23))
    {
        impacto = "Alto";
        Console.WriteLine($"Nivel de impacto: {impacto}");
        cantImpAlto++;
    }
    else if(nivelProduc == 2 || (duracion > 60 && duracion < 120))
    {
        impacto = "Medio";
        Console.WriteLine($"Nivel de impacto: {impacto}");
        cantImpMedio++;
    }
    else if(nivelProduc == 3 || duracion < 60)
    {
        impacto = "Bajo";
        Console.WriteLine($"Nivel de impacto: {impacto}");
        cantImpBajo++;
    }
}
void decisionFinal()
{
    if (errores > 1)
    {
        Console.WriteLine("El contenido a sido rechazado debido a el incumplimiento de muchas normas");
        totalIngresados++;
        cantRechazado++;
    }
    else if (errores == 0 && (impacto == "Medio" || impacto == "Bajo"))
    {
        Console.WriteLine("El contenido se puede publicar sin problema :)");
        totalIngresados++;
        cantPublicado++;
    }
    else if((errores <= 1 && errores > 0) && (impacto == "Medio" || impacto == "Bajo"))
    {
        Console.WriteLine("El contenido se puede publicar pero debe ser ajustado corrigiendo los errores mencionados");
        totalIngresados++;
        cantPublicado++;
    }
    else if((errores <= 1 && errores > 0) || impacto == "Alto")
    {
        Console.WriteLine("El contenido debe ser enviado a revisar debido a su impacto");
        totalIngresados++;
        cantRevision++;
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