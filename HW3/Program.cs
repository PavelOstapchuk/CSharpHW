// Задача 19.
// На вход 5-значное число. Проверить полиндромомность.

Console.WriteLine();
Console.WriteLine("Задача 19. Проверка 5-значного числа на полиндромность.");
Console.WriteLine("Вариант 1.");
int number = new Random().Next(10000, 100000);
//int number = int.Parse(Console.ReadLine()!); // для проверки
Console.WriteLine($"Заданное число {number}");
if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
{
    Console.WriteLine("Это число - полиндром.");
}
else
{
    Console.WriteLine("Это число НЕ полиндром.");
}
Console.WriteLine();

//Вариант 2.
Console.WriteLine("Вариант 2.");
Console.WriteLine("Введите 5-значное число: ");
string Numbers = Console.ReadLine();
if (Numbers.Length != 5)
{
    Console.WriteLine("Введено неверное число.");
}
else
{
    if (Numbers[0] == Numbers[4] && Numbers[1] == Numbers[3])
    {
        Console.WriteLine("Это полнидромное число.");
    }
    else
    {
        Console.WriteLine("Это НЕ полнидромное число.");
    }
}
Console.WriteLine();

// Задача 21/
// На вход - координты двух точек. 
// На выход - расстояние между ними в 3D пространстве.
Console.WriteLine();
Console.WriteLine("Задача 21. Находит расстояние между двумая точками по координатам в 3D просранстве.");
Console.WriteLine();
Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Z2: ");
int z2 = int.Parse(Console.ReadLine()!);
double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine();
Console.WriteLine($"Расстояние между точками равно {L:f2}."); // ":f2" - округляет double до 2 знака после запятой.
Console.WriteLine();


// задача 23.
// Принимает на вход число (N).
// На выход - таблица кубов от 1 до N (включительно).

Console.WriteLine();
Console.WriteLine("Задача 23. Выдает таблицу кубов от 1 до введенного числа.");
Console.WriteLine();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
for (int i=1; N>=i; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
Console.WriteLine();






// Черновики семнира 3.

// // Задача 1. По заданному номеру четверти 
// //показывает возможный диапазон координат 
// //точек в этой четверти (x и y).

// Console.WriteLine("Введите номре четверти: ");
// int number = int.Parse(Console.ReadLine()!); // ! - обозначает что значение не будет нулевым никога.

// switch (number)
// {
//     case 1:
//     {
//         Console.WriteLine("Это первая четверть.");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("Это вторая четверть.");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("Это третья четверть.");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("Это четвертая четверть.");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Не существует такой четверти.");
//         break;
//     }
// }


// // Задача 2.
// // Определить является ли заданное 6 значное число счастливым.
// // (сумма первых трех цифр равна сумме трех последних цифр).
// // (с проверкой на 6-ти значность).

// // Вариант1.
// int number = new Random().Next(100000,1000000);
// number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Введенное число {number}");

// if ((number/100000+number/10000%10+number/1000%10) == (number/100%10+number/10%10+number%10))
// {
//     Console.WriteLine("Это счастливое число!");
// }
// else
// {
//     Console.WriteLine("Это обычное число.");
// }

// //Вариант 2.
// Console.WriteLine("Введите шестизначное число: ");
// string Numbers = Console.ReadLine();
// if (Numbers.Length !=6)
// {
//     Console.WriteLine("Введено неверное число.");
// }
// else
// {
//     if (Numbers[0]+Numbers[1]+Numbers[2]==Numbers[3]+Numbers[4]+Numbers[5])
//     {
//         Console.WriteLine("Это счастливое число!");
//     }
//     else
//     {
//         Console.WriteLine("Это обычноео число.");
//     }
// }

// // Задача 3.
// // На вход - координты двух точек. 
// // На выход - расстояние между ними в 2D пространстве.
// // math .pow - степень, .sqrt - корень.
// Console.WriteLine();
// Console.WriteLine("Введите координаты первой точки:");
// Console.Write("X1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// Console.WriteLine("Введите координаты второй точки:");
// Console.Write("X2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Y2: ");
// int y2 = int.Parse(Console.ReadLine()!);

// double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// Console.WriteLine();
// Console.WriteLine($"Расстояние между точками равно {L:f2}."); // ":f2" - округляет double до 2 знака после запятой.


// // задача 4.
// // Принимает на вход число (N).
// // На выход - таблица квардртаов от 1 до N (включительно).
// Console.WriteLine();
// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// for (int i=1; N>=i; i++)
// {
//     Console.Write($"{Math.Pow(i, 2)} ");
// }
