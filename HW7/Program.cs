// домашнее задание 7.
Console.WriteLine();
Console.WriteLine($"Д/З #7. Введите номер задачи (47, 50, 52):");
int task = int.Parse(Console.ReadLine()!);
switch (task)
{
    case 47:
        // задача 1. Задать 2d массив m x n вещественных чисел
        // тип double. double RandomNextDuoble
        Console.WriteLine();
        Console.WriteLine($"Задача №{task}.");
        Console.WriteLine($"Задает 2d массив вещественных числе размера m x n.");
        Console.WriteLine("Введите количество строк массива: ");
        int rows47 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите количество столбцов массива: ");
        int columns47 = int.Parse(Console.ReadLine()!);
        double[,] array47 = Get2dDoubleArray(rows47,columns47,-10,10);
        Print2dDoubleArray(array47);

        break;
    case 50:
        // задача 2. Принимает два значения позиции элементма в 2d массиве
        // возвращает этот элемент или сообщение, что такого элемента нет.
        Console.WriteLine();
        Console.WriteLine($"Задача №{task}.");
        Console.WriteLine($"Находит элемент 2d массива по индексу позииции");
        Console.WriteLine("Введите количество строк массива: ");
        int rows50 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите количество столбцов массива: ");
        int columns50 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите индекс строки искомого элемента: ");
        int m50 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ведите индекс столбца искомого элемента: ");
        int n50 = int.Parse(Console.ReadLine()!);
        int[,] array50Int = Get2dIntArray(rows50, columns50, 0, 10);
        Console.WriteLine($"Начальный массив целых чисел: ");
        Print2dIntArray(array50Int);
        PrintElenemnt(m50, n50, array50Int);
        break;
    case 52:
        //задача 3. Найти среднее раифметическое элементов в
        //каждом столбце 2d массива из целых чисел.
        Console.WriteLine();
        Console.WriteLine($"Задача №{task}.");
        Console.WriteLine($"Найти средее арифметическое в каждом столбце 2d массива целых чисел.");
        Console.WriteLine("Введите количество строк массива: ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите количество столбцов массива: ");
        int columns = int.Parse(Console.ReadLine()!);
        int[,] array52 = Get2dIntArray(rows, columns, 0, 10);
        Console.WriteLine($"Начальный массив: ");
        Print2dIntArray(array52);
        AverageOfCollumns(array52);
        break;
}



//----methods-----
int[,] Get2dIntArray(int m, int n, int min, int max)
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
double[,] Get2dDoubleArray(int m, int n, int min, int max)
{
    double[,] newArray = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = min + new Random().NextDouble() * (max - min);
        }
    }
    return newArray;
}
void Print2dIntArray(int[,] array)
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
void Print2dDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}
void PrintElenemnt(int m, int n, int[,] array)
{
    if (m < array.GetLength(0) && n < array.GetLength(1))
    {
        Console.WriteLine($"Элемент массива с индексом [{m},{n}]: {array[m, n]}.");
    }
    else
    {
        Console.WriteLine($"Заданный индекс [{m},{n}] находится за пределами исследуемого массива.");

    }
}
void AverageOfCollumns(int[,] array)
{
    Console.WriteLine($"Средние арифметические по столбцам: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        Console.Write($"{(average / array.GetLength(0)):f2} ");
    }
}













// // Задача.
// // Задать двумерный массив размера m x n, 
// // заполненный случайными целыми числами.
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = Get2dArray(rows, columns, 0, 10);
// Print2dArray(array);


// //----methods-----
// int[,] Get2dArray(int m, int n, int min, int max) // метод создания 2d массива
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

// void Print2dArray(int[,] array)// метод печати 2d массива
// {
//     for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) - 0 означает длина по строчкам, 1 - длина по столбцам
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // GetLength(0) - 0 означает длина по строчкам, 1 - длина по столбцам
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// // Задача 48
// // Задчать 2d массив m x n, 
// // каждый элемент нахожится по формуле Amn = m+n
// // Вывести массив на экран.
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array48 = Get2dArray(rows, columns, 0, 10);
// Print2dArray(array48);

// //----methods-----
// int[,] Get2dArray(int m, int n, int min, int max)
// {
//     int[,] newArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i, j] = i+j;
//         }
//     }
//     return newArray;
// }

// void Print2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) - 0 означает длина по строчкам, 1 - длина по столбцам
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // GetLength(0) - 0 означает длина по строчкам, 1 - длина по столбцам
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Задача 49. Задать 2d массив. Найти элементы, у которых оба
// // индекса четные. Заменить эти индексы на их квадраты.
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array49 = Get2dArray(rows, columns, 0, 10);
// Console.WriteLine($"Начальный массив: ");
// Print2dArray(array49);
// Console.WriteLine($"Измененный масив (получение нового массива): ");
// int[,] array49Sqr = Get2dSqrArray(array49);
// Print2dArray(array49Sqr);
// Console.WriteLine($"Измененный масив (изменение старого массива): ");
// SqrEvenIndexArray(array49);
// Print2dArray(array49);

// //----methods-----
// int[,] Get2dArray(int m, int n, int min, int max)
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
// int[,] Get2dSqrArray(int[,] array)
// {
//     int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 newArray[i, j] = array[i, j] * array[i, j];
//             }
//             else
//             {
//                 newArray[i, j] = array[i, j];
//             }

//         }

//     }
//     return newArray;
// }
// void Print2dArray(int[,] array)
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
// void SqrEvenIndexArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i,j] = Convert.ToInt32(Math.Pow(array[i,j],2));
//             }
//         }
//     }
// }


// // Задача 51. Задать 2d массив. Найти сумму элементов,
// // находящихся на главной диагонали.
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array51 = Get2dArray(rows, columns, 0, 10);
// Console.WriteLine($"Начальный массив: ");
// Print2dArray(array51);
// Console.WriteLine($"Сумма элементов по главной диагонали равна: {GetSumMainDiagonal(array51)}");


// //----methods-----
// int[,] Get2dArray(int m, int n, int min, int max)
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
// int GetSumMainDiagonal(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i, j];
//             }

//         }

//     }
//     return sum;
// }
// void Print2dArray(int[,] array)
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




// // задача 333. Задать 2d массив. 
// // Отсортировать нечетные столбцы по возрастанию.
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array333 = Get2dArray(rows, columns, 0, 10);
// Console.WriteLine($"Начальный массив: ");
// Print2dArray(array333);
// Console.WriteLine($"Измененный масив (изменение старого массива): ");
// SortUnevenCollumns2(array333);
// Print2dArray(array333);

// //----methods-----
// int[,] Get2dArray(int m, int n, int min, int max)
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
// void Print2dArray(int[,] array)
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
// void SortCollumns(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             int minPos = i;
//             for (int k = i + 1; k < array.GetLength(0); k++)
//             {
//                 if (array[k, j] < array[minPos, j])
//                 {
//                     minPos = k;
//                 }
//             }
//             int temp = array[i, j];
//             array[i, j] = array[minPos, j];
//             array[minPos, j] = temp;
//         }
//     }
// }
// void SortUnevenCollumns(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//         if (j % 2 != 0)
//         {
//             for (int i = 0; i < array.GetLength(0) - 1; i++)
//             {
//                 int minPos = i;
//                 for (int k = i + 1; k < array.GetLength(0); k++)
//                 {
//                     if (array[k, j] < array[minPos, j])
//                     {
//                         minPos = k;
//                     }
//                 }
//                 int temp = array[i, j];
//                 array[i, j] = array[minPos, j];
//                 array[minPos, j] = temp;
//             }
//         }
//     }
// }
// void SortUnevenCollumns2(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//         if (j % 2 != 0)
//         {
//             bool flag = true;
//             while (flag)
//             {
//                 flag = false;
//                 for (int i = 0; i < array.GetLength(0) - 1; i++)
//                 {
//                     if (array[i, j] > array[i + 1, j])
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[i + 1, j];
//                         array[i + 1, j] = temp;
//                         flag = true;
//                     }
//                 }
//             }
//         }
//     }
// }










// // Задача 3. Задать 2d массив из целых чисел.
// // Найти среднеарифметическое из элементов в каждом столбце
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array3 = Get2dArray(rows, columns, 0, 10);
// Console.WriteLine($"Начальный массив: ");
// Print2dArray(array3);
// AverageOfCollumns(array3);


// //----methods-----
// int[,] Get2dArray(int m, int n, int min, int max)
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
// void Print2dArray(int[,] array)
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
// void AverageOfCollumns(int[,] array)
// {
//     Console.WriteLine($"Средние арифметические по столбцам: ");
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double average = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             average+=array[i,j];
//         }
//         Console.Write($"{(average/array.GetLength(0)):f2} ");
//     }
// }
