// Programa: 03-Operadores

Console.Write("Escribe el primer número entero (x): ");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Escribe el segundo número entero (y): ");
int y = int.Parse(Console.ReadLine() ?? "0");

// Si y es 0 no se puede dividir
if (y == 0)
{
    Console.WriteLine("No se puede dividir entre cero.");
    return;
}

// Operaciones básicas
int suma = x + y;
int resta = x - y;
int producto = x * y;

// División real: convierto x a double para que no se pierdan los decimales
double divisionReal = (double)x / y;

// División entera: int entre int da solo la parte entera
int divisionEntera = x / y;

// Residuo: lo que sobra de la división
int residuo = x % y;

// Es par si al dividir x entre 2 sobra 0
bool esPar = x % 2 == 0;

// Muestro todo con interpolación
Console.WriteLine();
Console.WriteLine($"Suma: {x} + {y} = {suma}");
Console.WriteLine($"Resta: {x} - {y} = {resta}");
Console.WriteLine($"Producto: {x} * {y} = {producto}");
Console.WriteLine($"División real: {x} / {y} = {divisionReal}");
Console.WriteLine($"División entera: {x} / {y} = {divisionEntera}");
Console.WriteLine($"Residuo: {x} % {y} = {residuo}");
Console.WriteLine($"¿{x} es par? {esPar}");

/*
PRUEBA DE ESCRITORIO (programa de la diapositiva)
Valores iniciales: int x = 10, y = 3;

Instrucción         | x  | y | Resultado
--------------------|----|---|------------------------------------------
int x = 10, y = 3;  | 10 | 3 | empiezan con estos valores
x / y               | 10 | 3 | 10 / 3 = 3 (división entera, se pierde el .33)
x % y               | 10 | 3 | 10 % 3 = 1 (3 * 3 = 9 y sobra 1)
x += y;             | 13 | 3 | x = 10 + 3, ahora x vale 13
y++;                | 13 | 4 | y = 3 + 1, ahora y vale 4
x > y && y != 4     | 13 | 4 | 13 > 4 es true, 4 != 4 es false
                    |    |   | true && false = false
*/