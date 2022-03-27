// See https://aka.ms/new-console-template for more information
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// using System;
// вариант с конвертацией числа в строку
// Console.WriteLine("Введите число");
// int Number = Convert.ToInt32(Console.ReadLine());
// string NumberString = Convert.ToString(Number);
// int summ = 0;
// int i = 0;
// while (i<NumberString.Length)
// {
//     summ = summ + NumberString[i];
//     i++;
// }
// Console.WriteLine($"Сумма цифр числа = {summ}");// 

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int summ=0;
int i=0;
while (Number>0)
{
    i = Number%10;
    summ = summ + i;
    Number = Number / 10;
}
Console.WriteLine($"Сумма цифр числа = {summ}");