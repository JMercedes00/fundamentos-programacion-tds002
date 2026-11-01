namespace _02_Variables;

class Program
{
    static void Main(string[] args)
    {
        // Constante con el año actual, no cambia mientras corre el programa
        const int ANIO_ACTUAL = 2026;

        // Pido los datos al usuario
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Escribe tu edad: ");
        int edad = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Escribe tu estatura en metros (ejemplo 1.65): ");
        double estatura = double.Parse(Console.ReadLine() ?? "0");

        // Calculo el año de nacimiento restando la edad al año actual
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Muestro todo usando interpolación con $"..."
        Console.WriteLine();
        Console.WriteLine($"Hola, {nombre}.");
        Console.WriteLine($"Tienes {edad} años y mides {estatura} metros.");
        Console.WriteLine($"Naciste aproximadamente en el año {anioNacimiento}.");
    }
}