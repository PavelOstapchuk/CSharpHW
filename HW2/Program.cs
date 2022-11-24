// базовые алгоритмы



// задача 1. Написать цело трехзначное число. Убрать вторую цифру из этого числа.
// 456 -> 46

// int number = new Random().Next(100, 1000);

// // первый метод (математичский):
// Console.WriteLine($"Выбранное число: {number}");
// Console.WriteLine($"Число без второй цифры имеет вид: {number / 100}{number % 10}");
// // или:
// int result = (number / 100) * 10 + number % 10;
// Console.WriteLine($"Число без второй цифры имеет вид: {result}");

// // второй метод (строковый):
// Console.WriteLine("Введите трехзначное число: ");
// string Numbers = Console.ReadLine();
// if (Numbers.Length != 3)
// {
//     Console.WriteLine("Введено неверное число.");
// }
// else
// {
//     Console.WriteLine($"Число без второй цифры имеет вид {Numbers[0]}{Numbers[2]}");

// }


// // Задача 2.1. Вывод случайного числа от 10 до 99, вывод наибольшей цифры этого числа.
// // вариант1:
// int number = new Random().Next(9, 99);
// Console.WriteLine($"Задано случайное число: {number}");
// int number1 = number / 10;
// int number2 = number % 10;
// if (number1 == number2)
// {
//     Console.WriteLine($"Обе цифры в числе: {number1}");
// }
// else
//     if (number2 > number1)
// {
//     Console.WriteLine($"Наибольшая цифра в заданном числе: {number2}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра в заданном числе: {number1}");
// }
// // // вариант 2:
// // Console.Write (new Random().Next(0, 9));
// // Console.Write (new Random().Next(0, 9));
// // string NewNumbers = Console.ReadLine();
// // if (NewNumbers[0] == NewNumbers[1])
// // {
// //     Console.WriteLine($"Обе цифры в числе: {NewNumbers[0]}");
// // }
// // else
// //     if (NewNumbers[0] > NewNumbers[1])
// // {
// //     Console.WriteLine($"Наибольшая цифра в заданном числе: {NewNumbers[0]}.");
// // }
// // else
// // {
// //     Console.WriteLine($"Наибольшая цифра в заданном числе: {NewNumbers[1]}.");
// // }


// // Задача 2.2. Ввод двух чисел, вывести является ли второе число кратным первому. Если не кратно, то вывести остаток.
// Console.WriteLine("Введите первое число: ");
// int a1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int a2 = int.Parse(Console.ReadLine()!);
// if (a2 > a1)
// {
//     Console.WriteLine($"Число {a1} не кратно числу {a2}, так как число {a2} больше числа {a1}");
// }
// else
// {
//     int result = a1 % a2;
//     if (result == 0)
//     {
//         Console.WriteLine($"Число {a1} кратно числу {a2}.");
//     }
//     else
//     {
//         Console.WriteLine($"Число {a1} не кратно числу {a2}, остаток от деления: {result}.");
//     }

// }

// // задача 3.1. Принимает на вход число (K). Проверка его одновременной кратности 7 и 23. 
// // (используется: логичское "И" - записывается "&&", логическое "или" - записывается "&"
// Console.WriteLine("Ведите число: ");
// int K = int.Parse(Console.ReadLine()!);
// if (K % 7 == 0 && K % 23 == 0)
// {
//     Console.WriteLine("Заданное число кратно 7 и 23");
// }
// else
//     if (K % 7 == 0 || K % 23 == 0)
//     {
//         Console.WriteLine("Заданное число кратно только одному из чисел 7 и 23.");
//     }
//     else
//     {
//         Console.WriteLine("Заданное число не кратно ни одному из чисел 7 и 23");
//     }

// // задача 3.2. Принимает на вход два числа. Провека является ли одно из них квадратом другого.
// Console.WriteLine("Введите первое число ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число ");
// int num2 = int.Parse(Console.ReadLine()!);
// if (num1*num1==num2 || num2*num2 == num1)
// {
//     Console.WriteLine("Одно из введных чисел является квадратом другого.");
// }
// else
// {
//     Console.WriteLine("Ни одно из введеных чисел не является квадратом другого.");
// }





// Практическое задание 2.
// Задача 10. Принимает на вход трехзначное числое. На выходе показывает 2ую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше трех знаков.
// Вариант 1:
Console.WriteLine("Задача 10. Ввод трехзначного числа. Вывод второй цифры.");
Console.WriteLine("Вариант 1.");
Console.WriteLine("Введите трехзначное число: ");
int NNN = int.Parse(Console.ReadLine()!);
if (NNN / 100 > 0 && NNN / 1000 == 0)
{
    Console.WriteLine($"Вторая цифра введенного числа: {(NNN % 100) / 10}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным.");
}
// Вариант 2:
Console.WriteLine();
Console.WriteLine("Вариант 2.");
Console.WriteLine("Введите трехзначное число: ");
string Numbers = Console.ReadLine();
if (Numbers.Length != 3)
{
    Console.WriteLine("Введеное число не является трехзначным.");
}
else
{
    Console.WriteLine($"Вторая цифра введенного числа: {Numbers[1]}");
}


// Задача 13. Вывод третьей цифры заданного числа или сообщение, что третьей цифры нет. Числа до 100000.
// Вариант 1:
int number = new Random().Next(1, 100001);
Console.WriteLine($"Выбранное число: {number}");
if (100 > number)
{
    Console.WriteLine("Третьей цыфры нет.");
}
else
{
    if (number < 999)
    {
        int result = number % 10;
        Console.WriteLine($"Третья цифра в выбранном числе: {result}");
    }
    if (999 < number && number < 10000)
    {
        int result = number % 100 / 10;
        Console.WriteLine($"Третья цифра в выбранном числе: {result}");
    }
    if (9999 < number && number < 100000)
    {
        int result = number % 1000 / 100;
        Console.WriteLine($"Третья цифра в выбранном числе: {result}");
    }
    if (number == 100000)
    {
        int result = number % 10000 / 1000;
        Console.WriteLine($"Третья цифра в выбранном числе: {result}");
    }
}
// Вариант 2:
Console.WriteLine("Введите число до 100000: ");
string Numbers = Console.ReadLine();
if (Numbers.Length > 6)
{
    Console.WriteLine("Введено слишком длинное число.");
}
if (Numbers.Length <3)
{
    Console.WriteLine("В введенном числе нет третьей цифры.");
}
else
{
    Console.WriteLine($"Третья цифра введенного числа:{Numbers[2]}");
}


// Задача 15. Принимает на вход цифру дня недели, проверяет является ли это день выходным. Обазательная проверка на ввод числа от 1 до 7.
Console.WriteLine("Введите порядковый номер дня недели: ");
int DayNumber = int.Parse(Console.ReadLine()!);
if (DayNumber > 7|| DayNumber <1)
{
    Console.WriteLine("Введен некорректный номер дня недели.");
}
else
{
    if (DayNumber<6)
    {
        Console.WriteLine("Это будний день.");     
    }
    else
    {
        Console.WriteLine("Это выхоной день.");
    }
}