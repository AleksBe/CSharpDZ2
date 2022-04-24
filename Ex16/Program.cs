Console.WriteLine("Введите координату X первой точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки:");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.Write("Расстояние между заданными точками: ");
Console.WriteLine("{0:0.00}", distance); // сократим до двух знаков после запятой