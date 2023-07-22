// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

string Sequence(int n)
{
    if (n > 0) return $"{n} " + Sequence(n - 1);
    else return string.Empty;
}

Console.WriteLine($"Последовательность чисел от N равна: {Sequence(n)}");