// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummNumbers (int M, int N)
{
    if (M <= N) return M + SummNumbers (M + 1, N);
    else return 0;
}

System.Console.WriteLine(SummNumbers (4, 8));