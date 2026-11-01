// Programa: FichaPersonal
// Pide mis datos y muestra una ficha con interpolación

// Constante con el año actual
const int anioActual = 2026;

// Pido los datos y los convierto al tipo que corresponde
Console.Write("Nombre: ");
string nombre = Console.ReadLine() ?? "";

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Estatura en metros (ejemplo 1.65): ");
double estatura = double.Parse(Console.ReadLine() ?? "0");

Console.Write("¿Trabajas? (true/false): ");
bool trabaja = bool.Parse(Console.ReadLine() ?? "false");

// Calculo el año en que voy a cumplir 30 años
int anioTreinta = anioActual + (30 - edad);

// Muestro la ficha con interpolación
Console.WriteLine();
Console.WriteLine("===== FICHA PERSONAL =====");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Estatura: {estatura} m");
Console.WriteLine($"Trabaja: {trabaja}");
Console.WriteLine($"Cumplirás 30 años en el {anioTreinta}");