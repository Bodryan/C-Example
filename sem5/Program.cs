void Zadacha31()
{
    /* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
    Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
    */

    int size = 12;
    int[] array = new int[size];
    int sumA = 0;
    int sumB = 0;

    FillArray(array, size);
    PrintArray(array, size);
    SumOfNumbers(array, sumA, sumB);
}

void Zadacha32()
{
    /* Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
    [-4, -8, 8, 2] -> [4, 8, -8, -2]
    */
    int size = 5;
    int[] array = new int[size];
    FillArray(array, size);
    PrintArray(array, size);
    Console.WriteLine();
    ReplacingАnItem(array, size);
    PrintArray(array, size);
}

void Zadacha33()
{
    /* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
    4; массив [6, 7, 19, 345, 3] -> нет
    3; массив [6, 7, 19, 345, 3] -> да
    */
    int size = 5;
    int[] array = new int[size];
    FillArray(array, size, 1, 5);
    PrintArray(array, size);
    Console.WriteLine();
    Console.WriteLine("Введите искомое число: ");
    int find = Convert.ToInt32(Console.ReadLine());
    FindNumberInArray(array, size, find);
}

void Zadacha35()
{
    // Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
    int size = 10;
    int[] array = new int[size];
    int sum = 0;
    FillArray(array, size, -99, 100);
    Console.WriteLine("Дан одномерны массив");
    PrintArray(array, size);
    Console.WriteLine();
    for (int i =0; i < size; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            sum++;
        }
    }
    Console.WriteLine($"Колличество элементов массива, значения которых лежат в отрезке [10,99] = {sum}");


}

void Zadacha37()
{
    // Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
    int size = 3;
    int[] array = new int[size];
    FillArray(array, size, 1, 21);
    Console.WriteLine("Дан одномерны массив");
    PrintArray(array, size);
    Console.WriteLine();
    int halfSize = size /2;
    int maxIndex = size - 1;

    for (int i = 0; i < halfSize; i++)
    {
        Console.WriteLine($"{array[i]} * {array[maxIndex - i]} = {array[i] * array[maxIndex - i]}");
    }

    if (size %2 == 1)
    {
        Console.WriteLine($"{array[halfSize]}");
    }


}

void FillArray(int[] arr, int size, int srartNumber = -10, int finishNumber = 10)
{
    Random random = new Random();
    finishNumber++;
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(srartNumber, finishNumber);
    }
}


void PrintArray(int[] arr, int size)
{
    for (int i =0; i < size; i++)
    {
        Console.Write($"[{arr[i]}] ");
    }
    Console.Write("\b");
}

void SumOfNumbers(int[] arr, int sum1, int sum2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sum1 += arr[i];
        }
        else
        {
            sum2 += arr[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма отрицательных чисел массива = {sum1}");
    Console.WriteLine($"Сумма положительных чисел массива = {sum2}");
}

void ReplacingАnItem(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] *= -1;
    }
}

void FindNumberInArray(int[] arr, int size, int f)
{
    bool flag = false;
    for (int i = 0; i < size && !flag; i++)
    {
        flag = f == arr[i];
    }
    if (flag)
    {
        Console.WriteLine($"Число {f} найдено в массиве.");
    }
    else
    {
        Console.WriteLine($"Число {f} не найдено в массиве.");
    }
}


// Zadacha33();
// Zadacha32();
// Zadacha31();
// Zadacha35();
// Zadacha37();

 