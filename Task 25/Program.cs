// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int NumberB = Convert.ToInt32(Console.ReadLine());
int NumberC = 0;
if (NumberB == 1) Console.WriteLine($"А в степени В = {NumberA}"); else
{for (int i=1; i<NumberB; i++)
    {NumberC = NumberC + NumberA * NumberA;
}
Console.WriteLine($"А в степени В = {NumberC}");
}