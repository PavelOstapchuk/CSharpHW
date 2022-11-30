Console.WriteLine();
Console.WriteLine($"Д/З #6. Введите номер задачи (41, 43):");
int task = int.Parse(Console.ReadLine()!);
switch (task)
{
    case 41:
        // задача 1. Ввод N чисел с клавиатуры
        // Посчитать сколько чисел  больше 0
        Console.WriteLine($"Задача {task}. Посчитать среди N введенных чисел количество чисел больше 0.");
        Console.WriteLine($"Введите количество задаваемых чисел:");
        int N41 = int.Parse(Console.ReadLine()!);
        int[] array41 = EnterNewArray(N41);
        Console.WriteLine($"[{String.Join(" ", array41)}]");
        Console.WriteLine($"{PositiveCount(array41)} из заданных чисел больше 0");
        break;
    case 43:
        // на вход массив не менее 6 элементов от 0 до 100
        // на выход - этот массив по возрастанию
        Console.WriteLine($"Задача {task}. Отсортировать по возрастанию массив в промежутке от 0 до 100.");
        Console.WriteLine($"Введите количество задаваемых чисел, не менее 6:");
        int N43 = int.Parse(Console.ReadLine()!);
        int[] array43 = GetRandArray(N43, 0, 100);
        Console.WriteLine($"Заданный массив:");
        Console.WriteLine($"[{String.Join(" ", array43)}]");



}
//----methods-----
int[] GetRandArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int[] EnterNewArray(int size)
{
    Console.WriteLine($"Введите последовательно через Enter {size} чисел:");

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите число:");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
int PositiveCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}
int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos])
            {
                minPos = j;
            }
        }
        
    }
}
// void selectionSort(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//     int minPos = i;
//     for (int j = i + 1; j < arr.Length; j++)
//     {
//         if (arr[j] < arr[minPos])
//         {
//             minPos = j;
//         }
//     }
//     int temp = arr[i];
//     arr[i] = arr[minPos];
//     arr[minPos] = temp;
//     }
// }



// // Заменить в тексте пробелы вертикальными черточками, 
// //маленькие к большими К, большие В на маленькие в.

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// // string s =  "qwerty"
// //              0123456
// // s[3] - r
// Console.WriteLine(text);
// Console.WriteLine();
// string Replace(string text, char oldSymb, char newSymb)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i =0; i < length; i++)
//     {
//         if (text[i] == oldSymb)
//         {
//             result=result+$"{newSymb}";
//         }
//         else
//         {
//             result = result + $"{text[i]}";
//         }
//     }
//     return result;
// }

// int[] GetRandArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// int[] GetEntArray5()
// {
//     int[] array = new int[5];
//     for (int i = 0; i < 5; i++)
//     {
//         Console.WriteLine($"Введите элемент массива №:{i+1}");
//         array[i] = int.Parse(Console.ReadLine()!);
//     }
//     return array;
// }















// // задача 39. Рзворот одномерного массива
// Console.WriteLine();
// Console.WriteLine($"задача 29. Рaзворот одномерного массива.");
// Console.WriteLine($"Введите размер массива:");
// int size39 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Введите min массива:");
// int min39 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Введите max массива:");
// int max39 = int.Parse(Console.ReadLine()!);

// int[] array = GetRandArray1D(size39, min39,max39);
// Console.WriteLine($"Заданый начальный массив:");
// Console.WriteLine($"[{String.Join(" ", array)}]");

// int[] revAr = GetReversedArray1D(array);
// Console.WriteLine($"Перевернутый массив 1 метод (создание нового массива):");
// Console.WriteLine($"[{String.Join(" ",revAr)}]");

// ReverseArray1D(array);
// Console.WriteLine($"Перевернутый массив 2 метод (вывод перевернутого массива):");
// Console.WriteLine($"[{String.Join(" ",array)}]");

// //-------methods------
// int[] GetRandArray1D(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ReverseArray1D(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
// }
// int[] GetReversedArray1D(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i]=array[array.Length - i - 1];
//     }
//     return newArray;
// }

// // Задача 40. На вход три числа. Проверяет, 
// // может ли существовать треугольник со сторонами такой длины. 
// // Теорема о неравенстве треугольника: 
// // каждая сторона треугольника меньше суммы двух других сторон.
// Console.WriteLine();
// Console.WriteLine($"задача 40. Проверка треугольника.");
// Console.WriteLine($"Введите размер 1 стороны:");
// int a40 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Введите размер 2 стороны:");
// int b40 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Введите размер 3 стророны:");
// int c40 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Такой треугольник {TriangleChek(a40, b40, c40)}");
// //-----methods-----
// bool TriangleChek(int a, int b, int c)
// {
//     if (a < (b + c) && b < (a + c) && c < (b + a))
//     {
//         return true;
//     }
//     return false;
// }


// // Задача 42: Напишите программу, которая будет преобразовывать 
// // десятичное число в двоичное.(число делится на 2 до 
// // самого конца, а потом остатки записываются, начиная с конца)
// Console.WriteLine();
// Console.WriteLine($"задача 42. Перевод десятичного в двоичного.");
// Console.WriteLine($"Десятичное число:");
// int a42 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"В двоичном коде по методу string: {GetBinString(a42)}");
// Console.WriteLine($"В двоичном коде пометоду viod:");
// GetBinArr(a42);

// //----methods-----
// string GetBinString(int N)
// {
//     string result = string.Empty;// задает начальную строку для вывода результата в виде строки (пустое занчение)
//     while (N != 0)
//     {
//         int temp = N % 2;
//         string tempString = Convert.ToString(temp);
//         N = N / 2;
//         result = result + temp;
//     }
//     return result;
// }
// void GetBinArr(int N)
// {
//     //int result = 0;
//     while (N != 0)
//     {
//         int temp = N % 2;
//         Console.Write(temp);
//         N = N / 2;
//        // result = result + temp;
//     }
//     //return result;
// }


// // Задача 44: Не используя рекурсию, выведите первые N 
// // чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// // (Числа Фибоначчи — числовая последовательность, 
// // каждый элемент которой равен сумме двух предыдущих.)
// Console.WriteLine();
// Console.WriteLine($"Задача 44. Вывести первые N чисел Фибоначи.");
// Console.WriteLine($"Введите N:");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Ряд Фибоначи по для {N} чисел (столбец представления f(N)):");
// GetFibo(N);
// Console.WriteLine($"Ряд Фибоначи по для {N} чисел (линия чисел):");
// GetFiboLine(N);
// //----methods----
// void GetFibo(int N)
// {
//     {
//         int temp0 = 0;
//         int temp1 = 1;
//         Console.WriteLine($"f(1)={temp0}");
//         Console.WriteLine($"f(2)={temp1}");
//         for (int i = 3; i <= N; i++)
//         {
//             int temp = temp1 + temp0;
//             Console.WriteLine($"f({i})={temp}");
//             temp0 = temp1;
//             temp1 = temp;
//         }
//     }
// }
// void GetFiboLine(int N)
// {
//     {
//         int temp0 = 0;
//         int temp1 = 1;
//         Console.Write($"{temp0}");
//         Console.Write($" {temp1}");
//         for (int i = 3; i <= N; i++)
//         {
//             int temp = temp1 + temp0;
//             Console.Write($" {temp}");
//             temp0 = temp1;
//             temp1 = temp;
//         }
//     }
// }


// // Задача 45: Напишите программу, которая будет создавать
// // копию заданного массива с помощью поэлементного копирования.
// Console.WriteLine();
// Console.WriteLine($"Задача 45. Создание массива поэлементным копированием начального массива.");
// Console.WriteLine($"Введите размер массива:");
// int size45 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Введите min массива:");
// int min45 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Введите max массива:");
// int max45 = int.Parse(Console.ReadLine()!);
// int[] array45 = GetRandArray(size45, min45, max45);
// Console.WriteLine($"[{String.Join(" ", array45)}]");
// Console.WriteLine($"[{String.Join(" ", GetNewCopiedArray(array45))}]");
// //------methods-----
// int[] GetRandArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] GetNewCopiedArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }
