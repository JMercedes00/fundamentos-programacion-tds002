// Programa: 07-Ciclos
// Pide un número del 1 al 12, muestra su tabla de multiplicar
// y al final suma todos los resultados

// ===== PARTE 1: PEDIR EL NÚMERO CON do-while =====
// do-while siempre se ejecuta al menos una vez y repite mientras el número no sea válido
int numero;

do
{
    Console.Write("Escribe un número entre 1 y 12: ");
    string entrada = Console.ReadLine() ?? "";

    // Si no es un número entero, TryParse deja numero en 0 (que no es válido)
    int.TryParse(entrada, out numero);

    if (numero < 1 || numero > 12)
    {
        Console.WriteLine("Número no válido. Intenta de nuevo.");
    }
}
while (numero < 1 || numero > 12);

// ===== PARTE 2: TABLA DE MULTIPLICAR CON while =====
int contador = 1;   // contador: va de 1 a 12
int suma = 0;       // acumulador: guarda la suma de los resultados

Console.WriteLine();
Console.WriteLine($"Tabla de multiplicar del {numero}:");

while (contador <= 12)
{
    int resultado = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {resultado}");

    suma += resultado;   // le sumo cada resultado al acumulador
    contador++;          // avanzo el contador para no hacer un ciclo infinito
}

// ===== PARTE 3: SUMA FINAL =====
Console.WriteLine();
Console.WriteLine($"La suma de todos los resultados es: {suma}");
