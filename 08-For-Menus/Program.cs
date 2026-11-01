// Programa: 08-For-Menus
// Menú con do-while y switch: tablas de multiplicar y triángulo de asteriscos

string opcion;

// do-while: muestra el menú al menos una vez y repite hasta que elijan 0
do
{
    Console.WriteLine();
    Console.WriteLine("===== MENÚ =====");
    Console.WriteLine("1. Tablas de multiplicar");
    Console.WriteLine("2. Triángulo de asteriscos");
    Console.WriteLine("0. Salir");
    Console.Write("Elige una opción: ");
    opcion = Console.ReadLine() ?? "";

    // switch decide qué hacer según la opción elegida
    switch (opcion)
    {
        case "1":
        {
            // Ciclos anidados: el for de afuera recorre las filas (1 al 10)
            // y el for de adentro recorre las columnas (1 al 10)
            Console.WriteLine();
            Console.WriteLine("Tablas de multiplicar del 1 al 10:");

            for (int fila = 1; fila <= 10; fila++)
            {
                for (int columna = 1; columna <= 10; columna++)
                {
                    // {valor,4} reserva 4 espacios y alinea el número a la derecha
                    Console.Write($"{fila * columna,4}");
                }

                // Al terminar las columnas, salto a la siguiente línea
                Console.WriteLine();
            }
            break;
        }

        case "2":
        {
            Console.Write("¿Cuántas filas tendrá el triángulo?: ");

            // Valido que N sea un entero mayor o igual a 1
            if (int.TryParse(Console.ReadLine(), out int filasTriangulo) && filasTriangulo >= 1)
            {
                Console.WriteLine();

                // El for de afuera recorre las filas y el de adentro
                // imprime tantos asteriscos como el número de la fila
                for (int fila = 1; fila <= filasTriangulo; fila++)
                {
                    for (int asterisco = 1; asterisco <= fila; asterisco++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Número no válido. Debe ser un entero mayor o igual a 1.");
            }
            break;
        }

        case "0":
            Console.WriteLine("Hasta luego.");
            break;

        default:
            Console.WriteLine("Opción no válida. Elige 1, 2 o 0.");
            break;
    }
}
while (opcion != "0");