using System;

namespace sem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha59()
            {
                // Задача 59: Задайтедвумерный массив из целых чисел.
                // Напишите программу, которая удалит строку и столбец, на
                // пересечении которых расположен наименьший элемент
                // массива.
                // Например, задан массив:
                // 1 4 7 2
                // 5 9 2 3
                // 8 4 2 4
                // 5 2 6 7
                // Наименьший элемент 1, на выходе получим
                // следующий массив:
                // 9 2 3
                // 4 2 4
                // 2 6 7

                int rows = 4;
                int colums = 4;
                int [,]array = new int[rows, colums];

                FillArray(array);
                PrintArray(array);
                Console.WriteLine();

                int min = array[0,0];
                int i_min = 0;
                int j_min = 0;
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (array[i,j] < min)
                        {
                            min = array[i,j];
                            i_min = i;
                            j_min = j;
                        } 
                    }
                }
                Console.WriteLine($"a[{i_min}, {j_min}] = {min}");
                Console.WriteLine();

                int rowResult = rows - 1;
                int columsResult = colums - 1;
                int [,]arrayResult = new int[rowResult, columsResult];
                int bias_i = 0;
                int bias_j = 0;

                for (int i = 0; i < rowResult; i++)
                {
                    if (i == i_min) bias_i++;
                    bias_j = 0;
                    for (int j = 0; j < columsResult; j++)
                    {
                        if (j == j_min) bias_j++;
                        arrayResult[i,j] = array[i + bias_i, j + bias_j];
                    }
                }
                PrintArray(arrayResult);

                
            }

            Zadacha59();
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
