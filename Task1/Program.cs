// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersFromNTo1 (int N)
{
    if (N > 0) return $"{N} " + NumbersFromNTo1 (N - 1);
    else return String.Empty;
}

System.Console.WriteLine(NumbersFromNTo1 (10));