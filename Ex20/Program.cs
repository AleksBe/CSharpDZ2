// Написать программу, которая принимает на вход число и выдает сумму цифр в числе.

// Данная программа будет работать только для целых чисел (положительных и отрицательных)

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int number = Math.Abs(a);      // Если введут отрицательное число

int summ = number % 10;

while(number / 10 > 0)
{
   number = number / 10;
   summ = summ + number % 10;
}

Console.WriteLine($"Сумма цифр числа = {summ}");

