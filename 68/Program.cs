﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

//A (m,n):
// если m=0, то n+1
// если m>0 && n=0, то A(m-1,1)
// если m>0 && n>0, то A(m-1,A(m,n-1))

Console.WriteLine("Введите неотрицательное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N:");
int n = Convert.ToInt32(Console.ReadLine());


int Ackermann(int m, int n)
{
   if (m == 0)
   {
      return n + 1;
   }
   if (m > 0 && n == 0)
   {
      return Ackermann(m - 1, 1);
   }
   if (m > 0 && n > 0)
   {
      return Ackermann(m - 1, Ackermann(m, n - 1));
   }

   return Ackermann(m, n);

}

int res = Ackermann(m, n);

Console.WriteLine(res);