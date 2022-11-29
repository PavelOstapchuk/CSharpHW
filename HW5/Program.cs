Console.WriteLine("Д/З №5. Введите номер задачи(34; 36; 37; 38):");
int task = int.Parse(Console.ReadLine()!);
switch (task)
{
    case 34:
    // задать случайный массив положиительных трехзначных чисел.
    // показать количесво четных чисел в массиве.
    // размерность массива не менее 5.
        Console.WriteLine("Задача 10. Показать количество четных чисел в случайном массиве положительных трехзначных чисел. Размерность не менее 5.");
        int[] arr34 = GetRandArray(5, 100, 999);
        Console.WriteLine($"Заданный массив:");
        Console.WriteLine($"[{String.Join(" ", arr34)}]");
        Console.WriteLine($"Количество четных чисел в заданном масииве: {FindQuantChet(arr34)}");
        break;
    case 36:
    // Задать одномерный массив слуйчайных чисел.
    // найти сумму элементов с нечетными индексами
        Console.WriteLine("Задача 36. Сумма элементов на нечетных позициях одномерного случайного массива.");
        Console.WriteLine($"Введите размер массива: ");
        int size = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Введите min массива: ");
        int min = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Введите max массива: ");
        int max = int.Parse(Console.ReadLine()!);
        int[] arr36 = GetRandArray(size, min, max);
        Console.WriteLine($"Заданный массив:");
        Console.WriteLine($"[{String.Join(" ", arr36)}]");
        Console.WriteLine($"Сумма чисел на нечётных индексах в массиве: {FindNechetIndexSum(arr36)}");
        break;
    case 37:
    // Найти произведение пар чисел в одномерном массиве
    // Пара - первый/последний, второй/предпоследний и т.д.
    // результат записать в новом массиве 
        Console.WriteLine("Задача 37. Образовать новый массив путем умножения пар чисел в начальном массиве от краев к центру.");
        int[] arr37size5 = GetRandArray(5, 0, 10); // проверка для нечетного количества элементов
        Console.WriteLine($"Начальный массив из 5 элементов:");
        Console.WriteLine($"[{String.Join(" ", arr37size5)}]");
        Console.WriteLine($"Новый массив:");
        Console.WriteLine($"[{String.Join(" ", GetNewMultArray(arr37size5))}]");
        int[] arr37size6 = GetRandArray(6, 0, 10); // проверка для четного числа элементов
        Console.WriteLine($"Начальный массив:");
        Console.WriteLine($"[{String.Join(" ", arr37size6)}]");
        Console.WriteLine($"Новый массив из 6 элементов:");
        Console.WriteLine($"[{String.Join(" ", GetNewMultArray(arr37size6))}]");
        break;
    case 38:
    // Задать массив целых чисел от -10 до 10.
    // Найти разницу между мах и min элементом массива.
        Console.WriteLine("Задача 38. Найти разницу между max и min элементами заданного массива целых чисел от -10 до 10.");
        Console.WriteLine($"Введите размер массива: ");
        int size38 = int.Parse(Console.ReadLine()!);
        int[] arr38 = GetRandArray(size38, -10, 10);
        Console.WriteLine($"Заданный массив:");
        Console.WriteLine($"[{String.Join(" ", arr38)}]");
        Console.WriteLine($"Разница между max и min элементом массива равна: {FindDifMinMax(arr38)}");
        break;
}
//-----methods-------
int[] GetRandArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int FindQuantChet(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
int FindNechetIndexSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count += array[i];
        }
    }
    return count;
}
int[] GetNewMultArray(int[] array)
{
    int[] newArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return newArray;
}
int FindDifMinMax(int[] array)
{
    int max = 0;
    int min = 0;
    foreach(int element in array)
    {
        if (element > max)
    {
        max = element;
    }
        if (element < min)
    {
        min = element;
    }
    }
    int dif = max - min;
    return dif;
}





// // switch case для задач
// Console.WriteLine("Д/З №5. Введите номер задачи(10; 13; 27):");
// int task = int.Parse(Console.ReadLine()!);
// switch (task)
// {
//     case 10:
//         Console.WriteLine("Задача 10.");
//         break;
//     case 13:
//         Console.WriteLine("Задача 13.");
//         break;
//     case 27:
//          Console.WriteLine("Задача 27.");
//         break;
// }


// // Задача 31. 
// // задать массив из 12 элементов.
// // заполнить случайными числами от -9 до 9.
// // найти сумму положительных и отрицательных элементов массива.
// int[] arr = GetArr(12,-9,9);
// Console.WriteLine($"[{String.Join(", ", arr)}]");
// int positiveSum = 0;
// int negativeSum = 0;
// foreach(int element in arr) // проходит по коллекции (строка, массив) по каждому элементу массива, перебирает по всем элементам, счетчик не нужен.
// {
//     if (element > 0)
//     {
//         positiveSum = positiveSum + element;
//     }
//     else
//     {
//         negativeSum +=element;
//     } 
// }
// Console.WriteLine($"Сумма положительных элементов: {positiveSum}; Сумма отрицательных элементов: {negativeSum}.");
// //------methods------
// int[] GetArr(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }


// // Задача 1.
// // Замена элементов массива:
// // положительные на отрицательные и наоброт.
// int[] arr1 = GetRandArray(5, -9, 9);
// Console.WriteLine($"[{String.Join(", ", arr1)}]");
// int[] contrArr1 = GetContrArray(arr1);
// Console.WriteLine($"[{String.Join(", ", contrArr1)}]");
// int[] arr2 = GetEnteredArray5(-9, 9);
// Console.WriteLine($"[{String.Join(", ", arr2)}]");
// int[] contrArr2 = GetContrArray(arr2);
// Console.WriteLine($"[{String.Join(", ", contrArr2)}]");
// //----methods----
// int[] GetRandArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// int[] GetEnteredArray5(int min, int max)
// {
//     int[] array = new int[5];
//     for (int i = 0; i < 5; i++)
//     {
//         Console.WriteLine($"Введите элемент массива №{i + 1}:");
//         array[i] = int.Parse(Console.ReadLine()!);
//     }
//     return array;
// }
// int[] GetContrArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -1 * array[i];
//     }
//     return array;
// }


// // Задача 2.
// // Определение есть ли в массиве заданое число.
// int[] arr1 = GetRandArray(5, -9, 9);
// Console.WriteLine($"[{String.Join(" ,", arr1)}]");
// FindNumber(arr1);
// int[] arr2 = GetEntArray5();
// Console.WriteLine($"[{String.Join(" ,", arr2)}]");
// FindNumber(arr2);
// //--------methods------
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
// void FindNumber(int[] array)
// {
//     Console.WriteLine($"Введите искомое число: ");
//     int N = int.Parse(Console.ReadLine()!);
//     int count = 0;
//     foreach (var item in array)
//     {
//         if (item == N)
//         {
//             Console.WriteLine($"В данном массиве есть число {N}.");
//             count += 1;
//             break;
//         }
//     }
//     if (count == 0)
//     {
//         Console.WriteLine($"В данном массиве нет числа {N}.");
//     }
// }


// // Задача 3.
// // задать одномерный массив из 123 случайных чисел.
// // найти количество элементов, лежащих в отрезке от 10 до 99.
// int[] arr3 = GetRandArray(123, 0, 200);
// int[] arr4 = GetRandArray(123, 10, 99);
// int[] arr5 = GetRandArray(123, 100, 200);
// Console.WriteLine($"[{String.Join(" ", arr3)}]");
// Console.WriteLine($"Количество элементов от 0 до 99: {FindQuant(arr3)}");
// Console.WriteLine($"[{String.Join(" ", arr4)}]");
// Console.WriteLine($"Количество элементов от 0 до 99: {FindQuant(arr4)}");
// Console.WriteLine($"[{String.Join(" ", arr5)}]");
// Console.WriteLine($"Количество элементов от 0 до 99: {FindQuant(arr5)}");

// //-------methods---------
// int[] GetRandArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// int FindQuant(int[] array)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if (item >= 10 && item <= 99)
//         {
//             count+=1;
//         }
//     }
//     return count;
// }
