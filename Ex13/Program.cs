Console.WriteLine("Введите число от 1 до 7, обозначающее день недели и мы скажем Вам является ли этот день выходным");
int a = Convert.ToInt32(Console.ReadLine());

if(a <= 0 ^ a > 7)
{
    Console.WriteLine ("Введено некорректное число");
}

else
{ 
    if(a > 5 && a < 8)
    {
    Console.WriteLine("Да");
    }
    else
    {
    Console.WriteLine("Нет");
    }
}
