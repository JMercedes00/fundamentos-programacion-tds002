// Programa: 06-Decisiones
// Parte 1: calificación con letra (if - else if - else)
// Parte 2: calculadora con switch

// ===== PARTE 1: CALIFICACIÓN =====
Console.WriteLine("===== CALIFICACIÓN =====");
Console.Write("Escribe una nota (0-100): ");
string entradaNota = Console.ReadLine() ?? "";

// int.TryParse devuelve false si lo escrito no es un número entero
// Además reviso que la nota esté entre 0 y 100
if (int.TryParse(entradaNota, out int nota) && nota >= 0 && nota <= 100)
{
    string letra;

    if (nota >= 90)
    {
        letra = "A";
    }
    else if (nota >= 80)
    {
        letra = "B";
    }
    else if (nota >= 70)
    {
        letra = "C";
    }
    else
    {
        letra = "F";
    }

    Console.WriteLine($"Nota {nota}: letra {letra}");
}
else
{
    Console.WriteLine("Nota no válida. Debe ser un número entero entre 0 y 100.");
}

// ===== PARTE 2: CALCULADORA =====
Console.WriteLine();
Console.WriteLine("===== CALCULADORA =====");

Console.Write("Primer número: ");
double numero1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Segundo número: ");
double numero2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Opciones: 1 sumar, 2 restar, 3 multiplicar, 4 dividir");
Console.Write("Elige una opción: ");
string opcion = Console.ReadLine() ?? "";

// switch elige qué operación hacer según la opción
switch (opcion)
{
    case "1":
        Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
        break;

    case "2":
        Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
        break;

    case "3":
        Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
        break;

    case "4":
        // Antes de dividir reviso que el segundo número no sea 0
        if (numero2 == 0)
        {
            Console.WriteLine("No se puede dividir entre 0.");
        }
        else
        {
            Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
        }
        break;

    default:
        Console.WriteLine("Opción no válida. Elige 1, 2, 3 o 4.");
        break;
}