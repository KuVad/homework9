// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите начало промежутка M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец промежутка N: ");
int N = int.Parse(Console.ReadLine());

int Summa(int M, int N)
{
    if (M == N) return N;
    else return M + Summa(M+1, N);
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {Summa(M, N)}");