int a = new Random().Next(10, 100); // Первое число - случайное двузначное число
int b = new Random().Next(1, 10); // Второе число - случайное однозначное число
System.Console.WriteLine($"a: {a} b: {b}"); // Чтобы понимать с какими числами мы работаем

int c = a % b;


if(c > 0) System.Console.WriteLine($"Число b не кратно числу а, остаток от деления {c}");
else Console.WriteLine("Число b кратно числу a");
