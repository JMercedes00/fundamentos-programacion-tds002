// Programa: PromedioValidado
// Pide notas de 0 a 100 hasta que el usuario escribe -1
// y muestra el promedio, la nota mayor y la nota menor

int cantidadNotas = 0;    // contador de notas
double suma = 0;          // acumulador de las notas
int notaMayor = 0;        // arranca en 0: cualquier nota válida es mayor o igual
int notaMenor = 100;      // arranca en 100: cualquier nota válida es menor o igual
bool seguir = true;

// while externo: sigue pidiendo notas hasta que escriban -1
while (seguir)
{
    int nota;
    bool esValida;

    // do-while interno: repite hasta que la entrada sea válida
    do
    {
        Console.Write("Escribe una nota (0-100, o -1 para terminar): ");
        string entrada = Console.ReadLine() ?? "";

        // Válida si es un entero entre 0 y 100, o el -1 para terminar
        esValida = int.TryParse(entrada, out nota) && ((nota >= 0 && nota <= 100) || nota == -1);

        if (!esValida)
        {
            Console.WriteLine("Nota no válida. Debe ser un entero entre 0 y 100 (o -1 para terminar).");
        }
    }
    while (!esValida);

    if (nota == -1)
    {
        seguir = false;
    }
    else
    {
        cantidadNotas++;   // contador
        suma += nota;      // acumulador

        if (nota > notaMayor)
        {
            notaMayor = nota;
        }

        if (nota < notaMenor)
        {
            notaMenor = nota;
        }
    }
}

// Muestro los resultados (si no escribieron notas, no hay nada que calcular)
Console.WriteLine();

if (cantidadNotas == 0)
{
    Console.WriteLine("No se escribieron notas.");
}
else
{
    double promedio = suma / cantidadNotas;

    Console.WriteLine("===== RESULTADOS =====");
    Console.WriteLine($"Notas escritas: {cantidadNotas}");
    Console.WriteLine($"Promedio: {promedio:F2}");
    Console.WriteLine($"Nota mayor: {notaMayor}");
    Console.WriteLine($"Nota menor: {notaMenor}");
}
