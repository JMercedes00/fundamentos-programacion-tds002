// Programa: 04-Secuencial
// Conversor de unidades: libras a kilogramos y grados Fahrenheit a Celsius

// Constante: cuántos kilogramos tiene 1 libra
const double KG_POR_LIBRA = 0.453592;

// ENTRADA: pido los datos al usuario
Console.Write("Escribe el peso en libras: ");
double libras = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Escribe la temperatura en °F: ");
double fahrenheit = double.Parse(Console.ReadLine() ?? "0");

// PROCESO: hacer las conversiones
double kilogramos = libras * KG_POR_LIBRA;
double celsius = (fahrenheit - 32) * 5 / 9;

// SALIDA: mostrar los resultados con 2 decimales (:F2)
Console.WriteLine();
Console.WriteLine($"{libras:F2} libras equivalen a {kilogramos:F2} kg.");
Console.WriteLine($"{fahrenheit:F2} °F equivalen a {celsius:F2} °C.");