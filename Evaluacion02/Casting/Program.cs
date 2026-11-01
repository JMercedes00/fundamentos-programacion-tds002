// Programa: Casting
// Demuestra el casting explícito (double a int) y el implícito (int a double)

Console.Write("Escribe un número con decimales: ");
double numero = double.Parse(Console.ReadLine() ?? "0");

// Casting explícito: hay que poner (int) y se pierde la parte decimal
int parteEntera = (int)numero;

// Casting implícito: C# convierte solo de int a double, sin poner nada
double enteroComoDouble = parteEntera;

Console.WriteLine();
Console.WriteLine($"Número original: {numero}");
Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");
Console.WriteLine($"Entero guardado en un double (casting implícito): {enteroComoDouble}");