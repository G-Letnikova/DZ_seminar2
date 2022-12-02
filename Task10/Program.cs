// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа
Console.Clear();

Console.WriteLine("введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N<0) N = (-1)*N;
if  (N>=99 && N<1000) Console.WriteLine($"{(N/10)%10}");
else Console.WriteLine($"ошибка! число не трехзначное");
