// Programa: AdivinaNumero
// El programa guarda un número secreto del 1 al 100 y el usuario intenta adivinarlo

// Número secreto aleatorio: Next(1, 101) da un número de 1 a 100
int numeroSecreto = Random.Shared.Next(1, 101);

int intentos = 0;       // contador de intentos
bool acerto = false;    // se vuelve true cuando adivina

Console.WriteLine("Adivina el número secreto (está entre 1 y 100).");

// do-while: pregunta al menos una vez y repite hasta que acierte
do
{
    Console.Write("Tu intento: ");
    string entrada = Console.ReadLine() ?? "";

    // Valido que sea un entero entre 1 y 100 (estos intentos no se cuentan)
    if (!int.TryParse(entrada, out int intento) || intento < 1 || intento > 100)
    {
        Console.WriteLine("Escribe un número entero entre 1 y 100.");
    }
    else
    {
        intentos++;   // sumo 1 al contador

        if (intento > numeroSecreto)
        {
            Console.WriteLine("El número secreto es menor.");
        }
        else if (intento < numeroSecreto)
        {
            Console.WriteLine("El número secreto es mayor.");
        }
        else
        {
            acerto = true;
        }
    }
}
while (!acerto);

Console.WriteLine();
Console.WriteLine($"¡Correcto! El número era {numeroSecreto}.");
Console.WriteLine($"Lo adivinaste en {intentos} intentos.");
