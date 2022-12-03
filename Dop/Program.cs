// Определить второй максимум. 
// Входные данные: гарантируется, что будет 0, и перед ним как минимум 2 числа
//

Console.Clear();

/*
Console.WriteLine("введите число: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число: ");
int max2 = Convert.ToInt32(Console.ReadLine());

if (max2 > max1) { int k = max1; max1 = max2; max2 = k; }

int n = max1;
*/


Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int max1 = n;
int max2 = n;


while (n != 0)
{
    if (n > max1) 
        { 
            max2 = max1;
            max1 = n;
        }
        else if (max2 == max1)   max2 = n;

    Console.WriteLine("введите число: ");
    n = Convert.ToInt32(Console.ReadLine());

}
if (max1 == max2) Console.WriteLine($"второй максимум = первому {max2}");
else Console.WriteLine($"второй максимум = {max2}");
