// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

void Numbers(int number, int i = 1)
{
   if (number < i)
   {
      return;
   }
   else
   {
      Numbers(number, i + 1);
      Console.Write(i + "  ");
   }
}

Numbers(number);
