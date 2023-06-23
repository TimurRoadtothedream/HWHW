// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
Console.WriteLine("Введите пятизначное число: "); 
int N = int.Parse(Console.ReadLine()); 
 
int result = 0; 
int N1 = N; 
 
if (N > 9999 && N < 100000) 
{ 
    while (N1 != 0) 
    { 
        result = (result * 10) + (N1 % 10); 
        N1 = N1 / 10; 
    } 
    if (N == result) 
    { 
    Console.WriteLine("Число является палиндромом"); 
    } 
    else 
    { 
        Console.WriteLine("Число не является палиндромом"); 
    } 
} 
else 
{ 
    Console.WriteLine("Число не пятизначное"); 
}