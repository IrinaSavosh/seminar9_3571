﻿// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число:");
int m = Convert.ToInt32(Console.ReadLine());


int Summ(int number)
{
   int sum = 0;
   if (number == 0)
   {
      return 0;
   }
   sum = Summ(number / 10) +  number % 10;

  return sum;

}

int sumNumbers = Summ(m);
Console.WriteLine(sumNumbers);