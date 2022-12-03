// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа 
// или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N<0) N = (-1)*N;

if (N<100) Console.WriteLine("третьей цифры нет");
else 
{while (N > 1000)
{
    N = N/10;
}
Console.WriteLine(N%10);
}
