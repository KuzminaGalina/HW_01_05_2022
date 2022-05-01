Console.WriteLine("Введите количество чисел ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ");
int max = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i++)
{
    Console.WriteLine("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > max) max = number;
}
Console.WriteLine("Максимальное число: " + max);