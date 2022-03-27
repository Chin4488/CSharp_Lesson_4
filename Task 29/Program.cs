// See https://aka.ms/new-console-template for more information
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите последовательно 8 чисел");
int[] array = new int[8];
for (int i=0; i<8; i++)
{
    Console.WriteLine($"Введите {i+1}-е число");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введен массив из 8 чисел");
for (int x=0; x<8; x++)
{
    Console.Write($"{array[x]} ");
}