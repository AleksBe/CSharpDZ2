int SecondFigure()// Сделаем в виде метода
{
int value = new Random().Next(100, 1000); // Пусть число будет случайным
System.Console.WriteLine($"Заданное число:{value}"); // Будем выводить число, для наглядности

int x = value / 10;
int a = x % 10;
return a;
}

System.Console.WriteLine($"Вторая цифра заданного числа:{SecondFigure()}");