int GetNumber()
{
int value = new Random().Next(10, 100);

int a = value / 10;
int b = value % 10;

System.Console.WriteLine($"value: {value}");
int max = a;
if (b > max) max = b;
return max;
}
System.Console.WriteLine($"Максимальное число: {GetNumber()}");