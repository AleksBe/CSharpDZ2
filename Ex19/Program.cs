// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// При написании программы 0 считать натуральным числом не будем.

//Console.WriteLine("Введите число А:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число B:");
//int b = Convert.ToInt32(Console.ReadLine());


double Stepen(int a, int b)
{
    double result = a;
    int i = 2;
    for(i = 2; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
double final = Stepen(a: 56, b: 7);  // Вариант, когда числа А и В не вводятся пользователем а "зашиваются" в метод.
Console.WriteLine(final);
