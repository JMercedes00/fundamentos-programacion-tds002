// Programa: Geometria
// Calcula el área y la circunferencia de un círculo
// y la hipotenusa de un triángulo rectángulo

// ENTRADA: pido el radio y los dos catetos
Console.Write("Radio del círculo: ");
double radio = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Cateto A del triángulo: ");
double catetoA = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Cateto B del triángulo: ");
double catetoB = double.Parse(Console.ReadLine() ?? "0");

// PROCESO: uso Math.PI, Math.Pow y Math.Sqrt
double areaCirculo = Math.PI * Math.Pow(radio, 2);
double circunferencia = 2 * Math.PI * radio;
double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

// SALIDA: resultados con 2 decimales (F2)
Console.WriteLine();
Console.WriteLine("===== CÍRCULO =====");
Console.WriteLine($"Área: {areaCirculo:F2}");
Console.WriteLine($"Circunferencia: {circunferencia:F2}");
Console.WriteLine();
Console.WriteLine("===== TRIÁNGULO RECTÁNGULO =====");
Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
