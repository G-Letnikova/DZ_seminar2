// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите число, обозначающее день недеи: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n<1 || n>7) 
{
    Console.Write("неверное число, нужно от 1 до 7. Введите число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n>=1 && n<=5) Console.Write("будни, иди работай!");
else Console.Write("Выходной, отдыхаем");
