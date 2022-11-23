// oneline comment

/*
fewline
comment
here
*/

// принимает на вход число, выдает квадрат этого числа

// Console.WriteLine("введи число: ");
// int number = int.Parse(Console.ReadLine()!); // Parse - преобразует тип string в тип Int, ! - убирает примечание (лампочка)

// вариант 1 (простой)
// int result1 = number * number;
// Console.WriteLine($"квадрат числа {number} равен {result1}"); //$ и {} позволяют обращаться к данным внутри выводной печатной строки

// вариант 2 (через встроенную библиотеку)
//int result2 = Convert.ToInt32(Math.Pow(number, 2)); // Math - библиотека мат.функицй. Pow - возводит в степерь в формате дабл-дабл. Convert - конвертирует. ToInt32 - в формат числа.
// Console.WriteLine($"квадрат числа {number} равен {result}")


/*
% - деление с остатком (выводит остаток)
/ - целочисленное деление (выводит целую часть)
*/


// Ввести число (N). Вывести все целые числа от -N до N.

// Console.WriteLine("введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int contrN = -N;
// while (contrN <= N)
// {
//     Console.Write($"{contrN}, ");
//     contrN = contrN + 1;
// }


// Ввести трехзначное число. Вывести последнюю цифру этого числа.

// Console.WriteLine("введите трехзначное число: ");
// int N = int.Parse(Console.ReadLine()!);
// int result = N%10;
// Console.WriteLine($"последняя цифра заданного числа это {result}");


// Ввести два числа. Проверить является ли 1-е число квадратом 2-го.


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