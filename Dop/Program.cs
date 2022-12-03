// Определить второй максимум. 
// Входные данные: гарантируется, что будет 0

Console.Clear();

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
if (max1 == max2) Console.WriteLine($"нет второго максимума, первый максимум = {max1}");
else Console.WriteLine($"второй максимум = {max2}");
