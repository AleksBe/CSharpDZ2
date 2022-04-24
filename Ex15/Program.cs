Console.WriteLine("Введите положительное пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99999 || number < 10000) Console.WriteLine("Введено некорректное число");
else
{
int a = number/10000;
int b = (number % 10000) / 1000;
int c = (number % 1000) / 100;
int d = (number % 100) / 10;
int e = number % 10;
    if(a + b + c == e + d + c) Console.WriteLine("Данное число является палиндромом");
    else
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}

