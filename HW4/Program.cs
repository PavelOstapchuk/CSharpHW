// Задача 25.
// Цикл, принимает на вход два числа (А) и (В).
// Возводит число А в натуральную степень В.

Console.WriteLine();
Console.WriteLine("Задча 25. Возведение числа (А) в натуральную степень (В).");
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно {GetDegree(A,B)}.");
//------methods----------
int GetDegree (int N1, int N2)
{
    int result = 1;
    for (int i = 1; i<=N2; i++)
    {
        result = result * N1;
    }
    return result;
}



// Задача 27.
// Принимает на вход число и выдает сумму цифр в числе.
Console.WriteLine();
Console.WriteLine("Задча 27. Сумма цифр заданного числа.");
Console.WriteLine("Введите число: ");
int A27 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {A27} по мат.методу равна {GetFigSum(A27)}.");
Console.WriteLine();
Console.WriteLine($"Сумма цифр числа {A27} по строч. методу равна {GetFigSum1(A27)}.");
//------methods----
int GetFigSum(int number)// некорректно работает с числами из 10 и более цифр.
{
    int sum = 0;
    while (number > 0)
    {
        int fig = number%10;
        number /= 10;
        sum = sum + fig;
    }
    return sum;
}
int GetFigSum1(int number)// полностью некорректный счет. Прибавляет помимо элементов еще + 49, +50 и так далее.
{
    string str = Convert.ToString(number);
    int sum = 0;
    for (int i = 0; i < str.Length; i++)
    {
        sum = sum + str[i];
        Console.WriteLine(sum);
    }
    return sum;
}


// Задача 29.
// Задает массив из 8 элементов. Выводит на экран. 
// Рандомные любые цифры.

Console.WriteLine();
Console.WriteLine("Задача 29. Вывод массива из 8 случайных элементов.");
Console.WriteLine("Введите MIN для элементов массива: ");
int min29 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите MAX для элементов массива: ");
int max29 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число элементов массива: ");
// int quant29 = int.Parse(Console.ReadLine()!);
int[] arr = GetBinarArr(8, min29, max29);
Console.WriteLine($"[{String.Join(" ", arr)}]");
//-----methods------
int[] GetBinarArr(int size, int min, int max)
{
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}






















// // заадча1.
// //Принимает на вход число A. 
// //На выход сумму чисел от 1 до А.

// Console.WriteLine("Введите число A: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}."); //можно сразу в Console.Readline поскольку программа завсисит только от одного метода.
// //----------methods---------
// int GetSum(int limit)
// {
//     int sum = 0;
//     for (int i = 0; i <= limit; i++)
//     {
//         sum = sum + i; // или sum += i
//     }
//     return sum;
// }

// // Задача 2.
// // Принимает на вход число. Выдает количество цифр в числе.
// // Решить математически 
// // (математическое действие прописасть в методе).
// Console.WriteLine();
// Console.WriteLine("задача 2. Вывод количества цифр в введенном числе.");
// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{GetQuant1(N)}");
// Console.WriteLine($"{GetQuant2(N)}");
// Console.WriteLine($"{GetQuant3(N)}");
// Console.WriteLine($"{GetQuant4(N)}");

// //----methods-----
// int GetQuant1(int number) // дает +1 к правльному ответу если цифра начинается с 5
// {
//     int sum = 0;
//     int i = 1;
//     int j = 1;
//     while (j > 0)
//     {
//         j = Convert.ToInt32(number / Math.Pow(10, i));
//         sum = sum + 1;
//         i = i + 1;
//     }
//     return sum;
// }
// int GetQuant2(int number)// дает +1 к правльному ответу если цифра начинается с 5
// {
//     int sum = Convert.ToInt32(Math.Log10(number)) + 1;
//     return sum;
// }
// int GetQuant3(int number)
// {
//     int sum = 1;
//     int i = 10;
//     while (number / i != 0)
//     {
//         sum = sum + 1;
//         i *= 10;
//     }
//     return sum;
// }
// int GetQuant4(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum++;
//         number /= 10;
//     }
//     return sum;
// }



//int result2 = Convert.ToInt32(Math.Pow(number, 2))

// // Задача 3. (метод учеников)
// // Выводит массив из 8-ми элементов 
// // заполненный 0 и 1 в случайном порядке.
// // Заполнение массива (можно ранодом) прописать в метод.
// Console.WriteLine();
// Console.WriteLine("задача 3. Вывод массива из 0 и 1 в случайном порядке.");
// int[] arr = new int[8];
// arr8(arr);
// Console.WriteLine($"[{String.Join(" ", arr)}]");// string.join - выводит массив через знак в " "
// //-----methods------
// int[] arr8(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(2);
//     }
//     return arr;
// }


// // Задача 3. (метод препод, универсальный)
// // Выводит массив из 8-ми элементов 
// // заполненный 0 и 1 в случайном порядке.
// // Заполнение массива (можно ранодом) прописать в метод.
// Console.WriteLine();
// Console.WriteLine("задача 3. Вывод массива из 0 и 1 в случайном порядке. Метод препод");
// int[] arr = GetBinarArr(8);
// Console.WriteLine($"[{String.Join(" ", arr)}]");// string.join - выводит массив через знак в " "
// //-----methods------
// int[] GetBinarArr(int size)
// {
//     int [] result = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }
//     return result;
// }


// // Задача 4.
// // Найти произведение всех элементов массива. 
// // целых чисел меньше задданого числа.
// // размерность массива - 10.
// // заполнение случайными числами от 50 до 100.
// Console.WriteLine();
// Console.WriteLine("задача 4. Произведение всех элементов случайного массива (элементы от 50 до 100), меньших заддного числа.");
// int[] arr = GetBinarArr(10);
// Console.WriteLine($"[{String.Join(" ", arr)}]");// string.join - выводит массив через знак в " "
// Console.WriteLine("Введите лимит элемента для произведения: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Произведение элементов, меньших {B} равно {GetMult(B,arr)}.");
// //-----methods------
// int[] GetBinarArr(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(50, 101);
//     }
//     return result;
// }
// int GetMult(int limit, int[] array)
// {
//     int result = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < limit)
//         {
//             result = result * array[i];
//         }
//     }
//     return result;
// }

