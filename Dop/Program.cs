// Второй максимум
//

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
        Console.WriteLine("введите число: ");
        n = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"второй максимум = {max2}");
