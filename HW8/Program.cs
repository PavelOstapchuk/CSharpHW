// домашнее задание 8.
Console.Clear();
Console.WriteLine();
Console.WriteLine($"Д/З #8. Введите номер задачи (54, 56, 58, 60, 62):");
int task = int.Parse(Console.ReadLine()!);
switch (task)
{
    case 54:
        // Задача 54: Задайте двумерный массив. 
        // Напишите программу, которая упорядочит по убыванию
        // элементы каждой строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 7 4 2 1
        // 9 5 3 2
        // 8 4 4 2
        Console.WriteLine($"Задача 54.");
        Console.WriteLine($"Упорядочивает по убыванию элементы каждой строки двухмерного массива.");       
        int[,] array1 = GetIntRandArray(3, 4, 0, 9);
        Console.WriteLine($"Заданный массив:");     
        PrintIntArray(array1);
        SortRows(array1);
        Console.WriteLine();
        Console.WriteLine($"Отсортированный массив:");
        PrintIntArray(array1);
         Console.WriteLine($"**********");       
        break;
    case 56:

        // Задача 56: Задайте прямоугольный двумерный массив. 
        // Напишите программу, которая будет находить строку 
        // с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и 
        //выдаёт номер строки с наименьшей суммой элементов: 1 строка
        Console.WriteLine($"Задача 56.");
        Console.WriteLine($"Находит строку с наименьшей суммой элементов прямоугольного 2d массива.");  
        int[,] array2 = GetIntRandArray(4, 4, 0, 9);
        Console.WriteLine($"Заданный массив:");     
        PrintIntArray(array2);
        Console.WriteLine($"Наименьшую сумму элементов имеет строка {FindMinElement(FindRowsSum(array2))}.");
        Console.WriteLine($"**********");
        break;
    case 58:
        // Задача 58: Задайте две матрицы. Напишите программу, 
        // которая будет находить произведение двух матриц.
        // Например, даны 2 матрицы:
        // 2 4 | 3 4
        // 3 2 | 3 3
        // Результирующая матрица будет:
        // 18 20
        // 15 18
        Console.WriteLine($"Задача 58.");
        Console.WriteLine($"Находит произведение двух матриц.");  
        int[,] array58A = {
        {2,4},
        {3,2}
        };
        int[,] array58B = {
        {3,4},
        {3,3},
        };
        Console.WriteLine($"Массив 1:");
        PrintIntArray(array58A);
        Console.WriteLine($"Массив 2:");
        PrintIntArray(array58B);
        if (array58A.GetLength(1) == array58B.GetLength(0))
        {
            int[,] array58 = ProduktOfArrays(array58A, array58B);
            Console.WriteLine($"Результат произведения массивов:");
            PrintIntArray(array58);
        }
        else
        {
            Console.WriteLine($"Произведение указазнных массивов невозможно. Количтество столбцов первого массива должно совпадать с количеством строк второго.");
        }
        Console.WriteLine($"**********");
        break;
    case 60:
        // Задача 60. ...Сформируйте трёхмерный массив 
        // из неповторяющихся двузначных чисел. 
        // Напишите программу, которая будет построчно 
        // выводить массив, добавляя индексы каждого элемента.
        // Массив размером 2 x 2 x 2
        // 66(0,0,0) 25(0,1,0)
        // 34(1,0,0) 41(1,1,0)
        // 27(0,0,1) 90(0,1,1)
        // 26(1,0,1) 55(1,1,1)
        Console.WriteLine($"Задача 60.");
        Console.WriteLine($"Построчный вывод трехмерного массива неповторяющихся чисел с индексами элементов.");  
        int[,,] array60 = Get3DRandUniqArray(2, 2, 2, 10, 99);
        Print2DArrayOf3Darray(array60);
        Console.WriteLine($"**********");
        break;
    case 62:
        // Задача 62. Напишите программу, которая заполнит 
        //спирально массив 4 на 4.
        // Например, на выходе получается вот такой массив:
        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07
        Console.WriteLine($"Задача 62.");
        Console.WriteLine($"Спиральное заполнение квадрaтного массива из N введных элементов.");  
        Console.WriteLine($"Введите чсило элментов заполняемого массива N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Введите {n} элементов массива через пробел: ");
        string str = new string(Console.ReadLine());
        //string str = "01 02 03 04 05 06 07 08 09 10 11 12 13 14 15 16";
        string[] array62 = GetArrayFromString(str);
        Console.WriteLine();
        string[,] checkingArray = CheckingArray(array62);
        if (array62.Length != array62.Length)
        {
            Console.WriteLine($"Введено число элементов, отличное от {n}. Построение спирального массива не возможно.");
        }
        else
        {
            Spyral2DOfStrinArray(1, 1, 0);
            Console.WriteLine($"Массив, спирально заполненный введными элементами:");
            PrintStrSpyralArray(checkingArray);
        }
        //---methods----
        void Spyral2DOfStrinArray(int row, int column, int count)
        {
            if (checkingArray[row, column] == "0")
            {
                checkingArray[row, column] = array62[count];
                count += 1;
                if (checkingArray[row - 1, column] != "0") { Spyral2DOfStrinArray(row, column + 1, count); }
                Spyral2DOfStrinArray(row + 1, column, count);
                Spyral2DOfStrinArray(row, column - 1, count);
                Spyral2DOfStrinArray(row - 1, column, count);

            }
        }
        Console.WriteLine($"**********");
        break;
}


//-------methods----------
int[,] GetIntRandArray(int m, int n, int min, int max)
{
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}
void PrintIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minPos = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] < array[i, minPos])
                {
                    minPos = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = array[i, minPos];
            array[i, minPos] = temp;
        }
    }
}
int[] FindRowsSum(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int RowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            RowSum += array[i, j];
        }
        newArray[i] = RowSum;
    }
    return newArray;
}
int FindMinElement(int[] array)
{
    int minElement = array[0];
    int minElementIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElement) { minElement = array[i]; minElementIndex = i; }
    }
    return minElementIndex;
}
int[,,] Get3DRandUniqArray(int x, int y, int z, int min, int max)
{
    int[,,] newArray = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                newArray[i, j, k] = new Random().Next(min, max + 1);
                if (k > 0)
                {
                    for (int i1 = i; i1! < 0; i1--)
                    {
                        for (int j1 = j; j1! < 0; j1--)
                        {
                            for (int k1 = k - 1; k1! < 0; k1--)
                            {
                                if (newArray[i, j, k] == newArray[i1, j1, k1])
                                {
                                    newArray[i, j, k] = new Random().Next(min, max + 1);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    return newArray;
}
void Print2DArrayOf3Darray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,] ProduktOfArrays(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int result = 0;
            for (int i1 = 0; i1 < array1.GetLength(1); i1++)
            {

                result += array1[i, i1] * array2[i1, j];

            }
            newArray[i, j] = result;
        }
    }
    return newArray;
}
string[] GetArrayFromString(string array)
{
    string[] newStringArray = array.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return newStringArray;
}
// void Spyral2DOfStrinArray(int row, int column, int count)
// {
//     if (checkingArray[row, column] == "0")
//     {
//         checkingArray[row, column] = array62[count];
//         count += 1;
//         if (checkingArray[row - 1, column] != "0") { Spyral2DOfStrinArray(row, column + 1, count); }
//         Spyral2DOfStrinArray(row + 1, column, count);
//         Spyral2DOfStrinArray(row, column - 1, count);
//         Spyral2DOfStrinArray(row - 1, column, count);

//     }
// }
void PrintStrSpyralArray(string[,] array)
{
    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < array.GetLength(1) - 1; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
string[,] CheckingArray(string[] array)
{
    int size = Convert.ToInt32(Math.Sqrt(array.Length));
    string[,] NewArray = new string[size + 2, size + 2];
    for (int i = 0; i < size + 2; i++)
    {
        for (int j = 0; j < size + 2; j++)
        {
            NewArray[i, j] = "0";
            if (i == 0) NewArray[i, j] = "1";
            if (j == 0) NewArray[i, j] = "1";
            if (i == size + 1) NewArray[i, j] = "1";
            if (j == size + 1) NewArray[i, j] = "1";
        }
    }
    return NewArray;
}





















// Console.Clear();
// // задача 1. задать 2d массив. Рандом.
// // Поменять первую и последнюю строку массива
// int[,] array1 = Get2dIntArray(3, 4, 0, 9);
// Print2dIntArray(array1);
// Console.WriteLine("*****************");
// int[,] newSortedArray1 = ReplaceRowsArray(array1);
// Print2dIntArray(newSortedArray1);
// Console.WriteLine("*****************");
// ReplaceRows(array1);
// Print2dIntArray(array1);

// // задача 2. задать 2d массив.
// // поменять строки и столбцы местами, если возможно.
// // вывести сообщение, если невозможно.
// Console.WriteLine("*****************");
// Console.WriteLine("*****************");
// int[,] array2 = Get2dIntArray(4, 5, 0, 9);
// Print2dIntArray(array2);
// Console.WriteLine("*****************");
// int[,] newArray2 = ReplaceRowsColumnsArray(array2);
// Print2dIntArray(newArray2);

// // задача 3.
// // В 2d массиве целых числе удалить строку и столбец
// // на пересечении которых расположен наименьший элемент.
// Console.WriteLine("*****************");
// int[,] array3 = Get2dIntArray(4, 5, 1, 9);
// Print2dIntArray(array3);
// Console.WriteLine("*****************");
// int[,] newArray3 = DeleteMinElementRowColumn(array3);
// Print2dIntArray(newArray3);
// int[,] newArray3V2 = DeleteMinElementRowColumnV2(array3);
// Print2dIntArray(newArray3V2);

// //------methods-----
// int[,] Get2dIntArray(int m, int n, int min, int max)
// {
//     int[,] newArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return newArray;
// }
// int[,] ReplaceRowsArray(int[,] array)
// {
//     int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLongLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == 0) newArray[i, j] = array[array.GetLength(0) - 1, j];
//             else if (i == array.GetLength(0) - 1) newArray[i, j] = array[0, j];
//             else newArray[i, j] = array[i, j];

//         }
//     }
//     return newArray;
// }
// void ReplaceRows(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
//     }
// }
// void Print2dIntArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ReplaceRowsColumnsArray(int[,] array)
// {
//     if (array.GetLength(0) == array.GetLength(1))
//     {
//         int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 newArray[j, i] = array[i, j];
//             }
//         }
//         return newArray;
//     }
//     else
//     {
//         Console.WriteLine($"Для данного массива замена невозможна. Количество строк должно быть равно количеству строк.");
//         return array;
//     }

// }
// int[,] DeleteMinElementRowColumn(int[,] array)
// {
//     int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     int min = array[0, 0];
//     int minI = 0;
//     int minJ = 0;
//     for (int i = 0; i < array.GetLength(0); i++)

//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 minI = i;
//                 minJ = j;
//             }
//         }
//     }
//     Console.WriteLine($"{minI},{minJ}");
//     for (int i = 0; i < array.GetLength(0) - 1; i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             if (i < minI)
//             {
//                 if (j < minJ)
//                 {
//                     newArray[i, j] = array[i, j];
//                 }
//                 else
//                 {
//                     newArray[i, j] = array[i, j + 1];
//                 }
//             }
//             else
//             {
//                 if (j < minJ)
//                 {
//                     newArray[i, j] = array[i + 1, j];
//                 }
//                 else
//                 {
//                     newArray[i, j] = array[i + 1, j + 1];
//                 }
//             }
//         }

//     }
//     return newArray;
// }
// int[,] DeleteMinElementRowColumnV2(int[,] array)
// {
//     int minI = 0, minJ = 0, min = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 minI = i;
//                 minJ = j;
//             }
//         }
//     }
//     int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
//     {
//         if (i == minI) { x--; continue; }
//         for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
//         {
//             if (j == minJ) { y--; continue;}
//             newArray[x, y] = array[i, j];
//         }
//     }
//     return newArray;
// }
