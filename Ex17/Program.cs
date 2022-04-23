Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int a = 1;
while(a <= n)
{
    System.Console.WriteLine($"{Math.Pow(a, 3)}");
    a++;
}