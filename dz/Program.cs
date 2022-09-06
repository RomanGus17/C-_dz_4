//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("Введите первое число"); //Вводим первое число
// int a = int.Parse(Console.ReadLine()); //Кладем первое число в переменную
// Console.WriteLine("Введите второе число"); //Вводим второе число
// int b = int.Parse(Console.ReadLine()); //Кладем второе число в переменную

// int temp = 1;
// double rez = 1;

// while (temp <= b)
// {
//     rez = (Math.Pow(a, b));
//     ++temp;
// }
// Console.WriteLine(rez);


//--------------------------------------------------------------------------------------------
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// int Sum(int a)
// {    
//     int n = Convert.ToString(a).Length;
//     int temp = 0;
//     int res = 0;

//     for (int i = 0; i < n; ++i){
//       temp = a - a % 10;
//       res = res + (a - temp);
//       a = a / 10;
//     }
//    return res;
//   }

// int sum = Sum(a);
// Console.WriteLine(sum);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Для первого массива
// int [] arr = {1, 2, 5, 7, 19};

// int cnt = arr.Length;

// for (int i = 0; i < cnt; i++)
// {
//     Console.Write($"{arr[i]} ");
// }
// Console.WriteLine();


//Для второго массива
// int [] arr = {6, 1, 33};

// int cnt = arr.Length;

// for (int i = 0; i < cnt; i++)
// {
//     Console.Write($"{arr[i]} ");
// }
// Console.WriteLine();