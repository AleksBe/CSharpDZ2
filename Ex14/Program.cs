Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 && y == 0) Console.WriteLine("Точка находится в начале координат");
if(x == 0 && y < 0) Console.WriteLine("Точка находится на границе  III и IV четверти");
if(x == 0 && y > 0) Console.WriteLine("Точка находится на границе  I и II четверти");
if(x > 0 && y == 0) Console.WriteLine("Точка находится на границе  I и IV четверти");
if(x < 0 && y == 0) Console.WriteLine("Точка находится на границе  II и III четверти");
if(x < 0 && y < 0) Console.WriteLine("Точка находится в III четверти");
if(x > 0 && y > 0) Console.WriteLine("Точка находится в I четверти");
if(x < 0 && y > 0) Console.WriteLine("Точка находится во II четверти");
if(x > 0 && y < 0) Console.WriteLine("Точка находится в IV четверти");

