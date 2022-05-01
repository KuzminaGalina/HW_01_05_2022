
Console.Write("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i = i + 2)
{
    Console.Write(i);
    if(i < n-1)
    {
        Console.Write(",");
    }
}

