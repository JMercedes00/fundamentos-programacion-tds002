// Programa: Factura
// Calcula subtotal, ITBIS y total, y muestra la factura en columnas alineadas

// Constante: porcentaje del ITBIS
const double ITBIS = 0.18; // 18 %

// ENTRADA: pido los datos de la compra
Console.Write("Producto (máximo 20 letras): ");
string producto = Console.ReadLine() ?? "";

Console.Write("Cantidad: ");
int cantidad = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Precio unitario: ");
double precio = double.Parse(Console.ReadLine() ?? "0");

// PROCESO: hago los cálculos
double subtotal = cantidad * precio;
double montoItbis = subtotal * ITBIS;
double total = subtotal + montoItbis;

// SALIDA: factura con columnas alineadas
// PadRight alinea a la izquierda y PadLeft a la derecha
Console.WriteLine();
Console.WriteLine("===== FACTURA =====");
Console.WriteLine("Producto".PadRight(20) + "Cant.".PadLeft(6) + "Precio".PadLeft(12) + "Importe".PadLeft(14));
Console.WriteLine(new string('-', 52));

// En la interpolación, {valor,12:N2} = ancho 12, alineado a la derecha, 2 decimales
Console.WriteLine($"{producto,-20}{cantidad,6}{precio,12:N2}{subtotal,14:N2}");
Console.WriteLine(new string('-', 52));

Console.WriteLine("Subtotal:".PadRight(38) + $"{subtotal,14:N2}");
Console.WriteLine("ITBIS (18 %):".PadRight(38) + $"{montoItbis,14:N2}");
Console.WriteLine("Total:".PadRight(38) + $"{total,14:N2}");
