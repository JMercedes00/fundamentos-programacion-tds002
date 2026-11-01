// Programa: Nomina
// Calcula el salario bruto, los descuentos de AFP y SFS y el salario neto

// Constantes: porcentajes de descuento
const double PORCENTAJE_AFP = 0.0287; // 2.87 %
const double PORCENTAJE_SFS = 0.0304; // 3.04 %

// ENTRADA: pido los datos del empleado
Console.Write("Nombre del empleado: ");
string nombre = Console.ReadLine() ?? "";

Console.Write("Horas trabajadas: ");
double horasTrabajadas = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Pago por hora: ");
double pagoPorHora = double.Parse(Console.ReadLine() ?? "0");

// PROCESO: hago los cálculos
double salarioBruto = horasTrabajadas * pagoPorHora;
double descuentoAfp = salarioBruto * PORCENTAJE_AFP;
double descuentoSfs = salarioBruto * PORCENTAJE_SFS;
double salarioNeto = salarioBruto - descuentoAfp - descuentoSfs;

// SALIDA: nombre en mayúsculas y montos con 2 decimales (N2)
Console.WriteLine();
Console.WriteLine("===== NÓMINA =====");
Console.WriteLine($"Empleado: {nombre.ToUpper()}");
Console.WriteLine($"Salario bruto: {salarioBruto:N2}");
Console.WriteLine($"AFP (2.87 %): {descuentoAfp:N2}");
Console.WriteLine($"SFS (3.04 %): {descuentoSfs:N2}");
Console.WriteLine($"Salario neto: {salarioNeto:N2}");