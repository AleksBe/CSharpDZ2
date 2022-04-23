Console.WriteLine("Введите отрицательное четырехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

if(-9999 < a && a < -1000)
{
    int b = a / (-10);
    int c = b / 10;
    int d = c * 10;
    int f = b - d;
    System.Console.WriteLine($"Вторая цифра числа: {f}");
}
else
{
    Console.WriteLine("Введенное число не соответвует условиям");
}
