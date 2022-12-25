﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите наименьшее число из двух задуманных:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наибольшее число из двух задуманных:");
int n = Convert.ToInt32(Console.ReadLine());

void Numbers(int m, int n)
{
   if (n< m)
   {
      return;
   }
   Numbers(m, n - 1);
   Console.Write(n + "  ");
}

Numbers(m, n);