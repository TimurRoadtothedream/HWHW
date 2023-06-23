// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
 
 
Console.WriteLine("Введите x1"); 
double x1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите y1"); 
double y1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите z1"); 
double z1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите x2"); 
double x2 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите y2"); 
double y2 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите z2"); 
double z2 = int.Parse(Console.ReadLine()); 
 
double A = x2 - x1; 
double B = y2 - y1; 
double C = z1 - z2; 
 
double length = Math.Sqrt(A * A + B * B + C * C); 
Console.WriteLine($"Длинна отрезка {length}");