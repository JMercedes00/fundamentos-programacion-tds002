// Programa: ConversorMoneda
// Convierte un monto en pesos a dólares usando la tasa del día

const double TASA_USD = 0.016;

Console.Write("Monto en pesos: ");
double montoPesos = Convert.ToDouble(Console.ReadLine());

// Multiplico el monto por la tasa para sacar los dólares
double montoDolares = montoPesos * TASA_USD;

Console.WriteLine();
Console.WriteLine($"{montoPesos:N2} pesos equivalen a {montoDolares:N2} dólares.");