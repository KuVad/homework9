// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int AkkermanFunct(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanFunct(m - 1, 1);
    else return AkkermanFunct(m - 1, AkkermanFunct(m, n -1));
}

Console.WriteLine($"Функция Аккермана равна: {AkkermanFunct(m, n)}");