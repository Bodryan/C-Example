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
                int rows = random.Next(4, 8);
                int colums = random.Next(4,8);
                int[,] array = new int[rows, colums];

                FillArray(array, -99, 99);
                PrintArray(array);



            }

            void FillArray(int[,] array, int startNumber = 0, int finisNember = 9)
            {
                Random random = new Random();
                finisNember++;
                int rows = array.GetLength(0);
                int colums = array.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        array[i, j] = random.Next(startNumber, finisNember);
                    }
                }
            }

            void PrintArray(int[,] array)
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

            Zadacha46();
        }
    }
}
