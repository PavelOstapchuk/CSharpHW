// Домашнее задание №9.
Console.Clear();
Console.WriteLine();
Console.WriteLine($"Д/З #8. Введите номер задачи (64, 66, 68):");
int task = int.Parse(Console.ReadLine()!);
switch (task)
{
    case 64:
        // Задача 64: Задайте значение N. 
        // Напишите программу, которая выведет
        // все натуральные числа в промежутке от N до 1.
        // Выполнить с помощью рекурсии.
        Console.WriteLine($"Задача №{task}. Нахоит натуральные числа в промежутке от N до 1.");
        Console.WriteLine("Введите N:");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine(PrintNumbers(n, 1));
        //----methods----
        string PrintNumbers(int start, int end)
        {
            if (start == end)
            {
                return start.ToString();
            }
            return (start + " " + PrintNumbers(start - 1, end));
        }
        break;
    case 66:
        // Задача 66: Задайте значения M и N. 
        //Напишите программу, которая найдёт сумму 
        //натуральных элементов в промежутке от M до N.
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30
        Console.WriteLine($"Задача №{task}. Находит сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("Введите M:");
        int m66 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите N:");
        int n66 = int.Parse(Console.ReadLine()!);
        if (m66 < n66)
        {
            Console.WriteLine($"Сумма натуральных элементов в заданном промежутке равна {SumOfNumbers(m66, n66)}");
        }
        else
        {
            if (m66 > n66)
            {
                Console.WriteLine($"Сумма натуральных элементов в заданном промежутке равна {SumOfNumbers(n66, m66)}");

            }
            else
            {
                Console.WriteLine($"Сумма натуральных элементов в заданном промежутке равна {n66 - m66}");
            }
        }
        //----methods----
        int SumOfNumbers(int m, int n)
        {
            if (n == m) { return m; }
            return n + SumOfNumbers(m, n - 1);
        }
        break;
    case 68:
        // Задача 68: Напишите программу 
        // вычисления функции Аккермана с помощью рекурсии.
        // Даны два неотрицательных числа m и n.
        Console.WriteLine($"Задача №{task}. Вычисление функции Аккермана по двум неотрицательным числам M до N.");
        Console.WriteLine("Введите M:");
        double m68 = Convert.ToDouble(Console.ReadLine()!);
        Console.WriteLine("Введите N:");
        double n68 = Convert.ToDouble(Console.ReadLine()!);
        if (m68 <0 && n68<0)
        {
            Console.WriteLine($"Введены некорректные аргументы.");
        }
        else
        {
            Console.WriteLine($"результат функции Аккермана для заданных аргументов равен {GetAkkerman(m68, n68)}");           
        }
        //----methods----
        double GetAkkerman(double m, double n)
        {
            if (m==0) return n+1;
            if (n==0) return GetAkkerman(m-1,1);
            return GetAkkerman(m-1,GetAkkerman(m,n-1));
        }
        break;

}

// // Задача 63: Задайте значение N. 
// // Напишите программу, которая выведет все натуральные числа 
// // в промежутке от 1 до N.
// // рекурсия.
// Console.WriteLine("Введите N:");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(1,n));
// //----methods----
// string PrintNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbers(start+1,end));
// }

// // Задача 65: Задайте значения M и N. 
// // Напишите программу, которая выведет все натуральные числа 
// // в промежутке от M до N.
// Console.WriteLine("Введите N:");
// int n65 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите M:");
// int m65 = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers65(n65,m65));
// //----methods----
// string PrintNumbers65(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbers65(start+1,end));
// }

// // Задача 67: Принимает на вход число.
// // Возвращает сумму его цифр.
// Console.WriteLine("Введите число:");
// int n67 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Суммы цифр числа {n67} равна {GetFigureSum(n67)}.");
// //----methods----
// int GetFigureSum(int n)
// {
//     if (n == 0) return 0;
//     {
//         return n % 10 + GetFigureSum(n / 10);
//     }
// }

// // Задача 69: Принимает два числа M и N. 
// // Возводит число M в целую степень N с помощью рекурсии.
// Console.WriteLine("Введите M:");
// int m69 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите N:");
// int n69 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"число {m69} в степени {n69} равно {Exponention(m69,n69)}.");
// //----methods----
// int Exponention (int a, int b)
// {
//     if (b == 0)
//     {
//         return 1;
//     }
//     return a * Exponention(a,b-1);
// }
