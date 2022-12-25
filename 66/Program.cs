// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());


int Summ(int smallerNumber, int biggerNumber)
{
   int sum = 0;
   if (smallerNumber > biggerNumber)
   {
      return 0;
   }
   sum = smallerNumber + Summ(smallerNumber+1, biggerNumber);

   return sum;

}

// 5 = 4+1 = 3+1+1 = 2+1+1+1 = 1+1+1+1+1



int sumNumbers = 0;
if (n > m)
{
   sumNumbers = Summ(m, n);
}
else
{
   sumNumbers = Summ(n, m);
}
Console.WriteLine(sumNumbers);