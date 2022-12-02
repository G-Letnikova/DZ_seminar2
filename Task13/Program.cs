// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N<0) N = (-1)*N;

if (N>-100 && N<100) Console.WriteLine("третьей цифры нет");
else         Console.WriteLine($"{(N/100)%10}");
