// Урок 4. Функции продолжение

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// System.Console.Write("Введите первое число  : ");
// int A = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число  : ");
// int B = Convert.ToInt32(Console.ReadLine());
// int StepenA =1 ; 
// Stepen(A ,B );
// System.Console.Write($"{A} в степени {B} = {StepenA} ");

// void Stepen (int A , int B) 
// {
//     for (int i = 0; i < B; i++)
//     {
//         StepenA = StepenA*A;
//     }
// }

// End



// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.Write("Введите число  : ");
// int A = Convert.ToInt32(Console.ReadLine());
// int Sum = 0;

//  while ( A > 0)
//     {
//         int TempA = A%10;
//         Sum = Sum + TempA;
//         A = A/10;
//     }
// System.Console.Write(Sum);

//End


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int size = 8 ;
int[] array = new int[size];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
    {   
        for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,100);
    }

void PrintArray(int[] array)
    {   
        System.Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        System.Console.Write("]");
    }

//End