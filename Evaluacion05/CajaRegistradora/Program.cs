// Programa: CajaRegistradora
// Lee precios hasta que el usuario escribe 0 y calcula subtotal, ITBIS y total

// Constante: porcentaje del ITBIS
const double ITBIS = 0.18; // 18 %

int cantidadProductos = 0;   // contador de productos
double subtotal = 0;         // acumulador de precios
bool terminar = false;       // se vuelve true cuando el usuario escribe 0

// do-while: pide precios al menos una vez y repite hasta que escriban 0
do
{
    Console.Write("Precio del producto (0 para terminar): ");
    string entrada = Console.ReadLine() ?? "";

    // TryParse evita que el programa se caiga si escriben letras
    if (!double.TryParse(entrada, out double precio) || precio < 0)
    {
        Console.WriteLine("Precio no válido. Escribe un número mayor o igual a 0.");
    }
    else if (precio == 0)
    {
        terminar = true;
    }
    else
    {
        cantidadProductos++;   // sumo 1 al contador
        subtotal += precio;    // sumo el precio al acumulador
    }
}
while (!terminar);

// Calculo el ITBIS y el total
double montoItbis = subtotal * ITBIS;
double total = subtotal + montoItbis;

// Muestro el resumen con 2 decimales (N2)
Console.WriteLine();
Console.WriteLine("===== RESUMEN DE LA COMPRA =====");
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {subtotal:N2}");
Console.WriteLine($"ITBIS (18 %): {montoItbis:N2}");
Console.WriteLine($"Total: {total:N2}");
