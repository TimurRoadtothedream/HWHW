// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Console.WriteLine("Введите число: "); 
int N = int.Parse(Console.ReadLine()); 
 
for (int kub = 1; kub <= N; kub++) 
{ 
    Console.WriteLine($"{kub*kub*kub}"); 
}