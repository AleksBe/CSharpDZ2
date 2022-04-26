// Задача. Найти сумму чисел от 1 до А.
// Пусть число А может быть как положительным, так отрицательным так и нулем. Сделаем метод для каждого случая.
// Затем, в зависимости от условия применим тот или иной метод и выведем результат

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

void Zero() // Если A == 0
{
   Console.WriteLine("Сумма = 1");
}

int Plus() // Если A > 0
{
    int Summ = 0;
    for(int i = 0; i <= a; i++)
    {
        Summ = Summ + i;
    }
    return Summ;
}

int Minus() // Если A < 0
{
    int Summ = 0;
    for(int i = a; i <= 1; i++)
    {
        Summ = Summ + i;
    }
    return Summ;
}

if(a == 0) Zero();
if(a > 0) Console.WriteLine($"Сумма = {Plus()}");
if(a < 0) Console.WriteLine($"Сумма = {Minus()}");


