Console.Write ("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Первое число равно: " + a);

Console.Write ("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Второе число равно: " + b);

int max = 1;
 
 if (a > b) 
 max = a;
 else 
 max = b;

 Console.WriteLine ("Максимальное значение равно " + max);
