// Практическое задание 1. С#.

// Задача 2. Принимает на вход 2 числа. На выход выдает какое больше, какое меньше.
Console.WriteLine("Определение большего/меньшего из двух чисел.");
Console.WriteLine("введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
if (A == B)
{
    Console.WriteLine("Невозможно определить (числа равны).");
}
if (A > B)
{
    Console.WriteLine($"Болшее из чисел: {A}, меньшее из чисел: {B}.");
}
if (B > A)
{
    Console.WriteLine($"Болшее из чисел: {B}, меньшее из чисел: {A}.");
}


// Задача 4. Принимает на вход 3 числа. На выход выдает максимальное из этих трех.
Console.WriteLine("Определение максимального из трех чисел.");
Console.WriteLine("введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"Максимальное из введeнных чисел: {max}.");

// Задача 6. Принимает на вход число. Выдает является ли число четным (делится на 2 без остатка).
Console.WriteLine("Определение четности введенного числа.");
Console.WriteLine("введите число: ");
int chet = int.Parse(Console.ReadLine()!);
if (chet % 2 == 0)
{
    Console.WriteLine("Введенное число является четным");
}
else
{
    Console.WriteLine("Введенное число является нечетным");
}

// Задача 8. Принимает на вход число (N), на выход выдает все четные числа от 1 до N (Вариант 1).
Console.WriteLine("Вывод все четных чисел от 1 до введенного числа.");
Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N1 = 2;
while (N1 <= N)
{
    if (N1 % 2 == 0)
    {
        Console.Write($"{N1}, ");
        N1 = N1 + 1;
    }
    N1 = N1 + 1;
}

// Задача 8. Принимает на вход число (N), на выход выдает все четные числа от 1 до N (Вариант 2).
Console.WriteLine("Вывод все четных чисел от 1 до введенного числа.");
Console.WriteLine("введите число: ");
int M = int.Parse(Console.ReadLine()!);
int M1 = 2;
while (M1 <= M)
{
    Console.Write($"{M1}, ");
    M1 = M1 + 2;
}