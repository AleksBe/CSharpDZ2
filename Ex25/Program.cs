//Дано число из отрезка [10, 99999]. Показать наибольшую цифру числа

//int number = new Random().Next(10, 100000);
//Console.WriteLine(number);

int MaxNumber(int number)
{
    int max = number % 10;

    while (number / 10 > 0)
    {
    int b = (number / 10) % 10;
    if(b > max) max = b;
    
    number = number / 10; 
    }
    return max;
}
int result = MaxNumber(65375);  // Здесь вводим число
Console.WriteLine($"Наибольшая цифра числа: {result}");
