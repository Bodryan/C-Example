using System;

namespace sem7
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha46()
                    
            {
                //Zadacha 46: Задайте двумерный массив размером m×n,
                // заполненный случайными целыми числами.
                // m = 3, n = 4.
                // 1 4 8 19
                // 5 -2 33 -2
                // 77 3 8 1

                Random random = new Random();
                int rows = 4;// random.Next(4, 8);
                int colums = 6;// random.Next(4,8);
                int[,] array = new int[rows, colums];

                FillArraySumIndex(array);
                PrintArray(array);
            }

            // Zadacha46();

            void Zadacha49()

            {
                // Задача 49: Задайте двумерный массив. Найдите элементы, у
                // которых оба индекса чётные, и замените эти элементы на их 
                // квадраты.
                // Например, изначально массив      Новый массив будет выглядеть
                // выглядел вот так:                вот так:
                // 1 4 7 2                          1 4 7 2
                // 5 9 2 3                          5 81 2 9
                // 8 4 2 4                          8 4 2 4

                int rows = 2;
                int colums = 3;
                int[,] array = new int[rows,colums];

                FillArray(array);
                PrintArray(array);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                        {
                            array[i,j] *= array[i,j];
                        }          
                    }
                }
                Console.WriteLine();
                PrintArray(array);
            }

            // Zadacha49();     


             void Zadacha51()
             {
                // Задача 51: Задайте двумерный массив. Найдите сумму
                // элементов, находящихся на главной диагонали (с индексами (0,0);
                // (1;1) и т.д.
                // Например, задан массив:
                //      1 4 7 2
                //      5 9 2 3
                //      8 4 2 4
                // Сумма элементов главной диагонали: 1+9+2 = 12

                int rows = 5;
                int colums = 5;
                int[,] array = new int[rows,colums];
                int sum = 0;

                FillArray(array);
                PrintArray(array);
                Console.WriteLine();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (i == j)
                        {
                            sum += array[i,j];
                            Console.Write(array[i,j] + " +" + " ");
                        }
                    }
                }
                Console.WriteLine("\b" + " = " + sum);
                Console.WriteLine("Сумма элементов главной диагонали:" + " " + sum);                  
             }

             // Zadacha51();      
        }

        static void FillArray(int[,] array, int startNumber = 1, int finishNumber = 10)
        {
            Random random = new Random();
            finishNumber++;
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array[i, j] = random.Next(startNumber, finishNumber);
                }
            }
        }

        static void FillArraySumIndex(int[,] array)
        {
            Random random = new Random();
            // finisNember++;
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array[i, j] = i + j;
                }
            }
        }
        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
