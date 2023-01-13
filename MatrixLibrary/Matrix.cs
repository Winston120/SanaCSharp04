using System;
using System.Data;
using System.Xml.Linq;

namespace MatrixLibrary
{
    public class Matrix
    {
        public static int[,] GenerateMatrix (int rowCount, int colCount)
        {
            int[,] matrix = new int[rowCount, colCount];
            Random random = new Random();
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i,j] = random.Next(-9,9);
                }
            return matrix;
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{ matrix[i, j],3}");
                }
                Console.WriteLine();
            }
        }
        public static int CountPositiveElements(int[,] matrix)
        {
            int res = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) res++;
                }
            }
            return res;
        }

        public static string MaxElementOfRepeat(int[,] matrix)
        {
            int res = int.MinValue, count = 0;
            bool n = false;
            int[] mas = new int[matrix.GetLength(0) * matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    mas[count] = matrix[i, j];
                    count++;
                }
            Array.Sort(mas);
            Array.Reverse(mas);
            for (int i = 0; i < (mas.Length)-1; i++)
            {
                if (mas[i] == mas[i + 1])
                {
                    res = mas[i];
                    n = true;
                    break;
                }
            }
            if (n == true) return $"Максимальне число, що повторюється в масиві - {res}";
            else return "В матриці немає максимального числа, що повторюється більше 2 разів";
        }
    }
}