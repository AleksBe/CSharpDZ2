// Написать программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int len = number.Length;

Console.WriteLine(len);
int summ = 0;
for(int i = 0; i < len; i++)
   {
      summ = summ + number[i];
   }
   Console.WriteLine(summ);
//int[] array = new int [len];

//int summ = 0;
//for(int i = 0; i < len; i++)
//{
   //array[i] = Convert.ToInt32(number[i]);
  // Console.WriteLine(array[i]);
   //summ = summ + array[i];
    
//}
//Console.WriteLine(summ);

//int[] CreateArray(int len)  // Создаем массив
//{
    //int[] result = new int[len];
    //return result;
//}

//int FillArrayAndSumm(int[] array) // Заполняем массив
//{
   // int Summ = 0;
   // for(int i = 0; i < len; i++)
   // {
      //  array[i] = number[i];
      //  Summ = Summ + array[i];
    //}
   // return Summ;
//}
//int Summa(int[] array) // Считаем сумму элементов массива
//{
 //   int Summ = 0;
 //   for(int i = 0; i < len; i++);
  //  {
    //    Summ = Summ + array[i];
   // }
   // return Summ;
//}

//int[] arr = CreateArray(len);
//Summa(FillArray(arr));
//Console.WriteLine($"Сумма цифр введенного числа = {FillArrayAndSumm(arr)}");


//int Summ = 0;
//int i = 0;
//int len = array.Lenth;

//for(i = 0; i < len; i++)
//{
    //Summ = Summ + array[i];
//}
//Console.WriteLine($"Сумма цифр числа = {Summ} ");

