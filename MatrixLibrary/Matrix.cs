using System;
using System.Data;
using System.Xml.Linq;

namespace MatrixLibrary
{
    public class Matrix
    {
        public static int[,] GenerateMatrix(int rowCount, int colCount)
        {
            int[,] matrix = new int[rowCount, colCount];
            Random random = new Random();
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = random.Next(-9, 10);
                }
            return matrix;
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],3}");
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
            int[] mas = new int[matrix.GetLength(0) * matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    mas[count] = matrix[i, j];
                    count++;
                }
            Array.Sort(mas);
            Array.Reverse(mas);
            for (int i = 0; i < (mas.Length) - 1; i++)
            {
                if (mas[i] == mas[i + 1])
                {
                    res = mas[i];
                    n = true;
                    break;
                }
            }
            if (n == true) return $"Максимальне число, що повторюється в масиві = {res}";
            else return "В матриці немає максимального числа, що повторюється більше 2 разів";
        }

        public static int CountRowNotСontainZeroElement(int[,] matrix)
        {
            bool n = true;
            int res = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                n = true;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        n = false;
                        break;
                    }
                }
                if (n) res++;
            }
            return res;
        }
        public static int CountColumnHaveZeroElement(int[,] matrix)
        {
            bool n = false;
            int res = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                n = false;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        n = true;
                        break;
                    }
                }
                if (n) res++;
            }
            return res;
        }
        public static string RowIndexLongestSeriesOfIdenticalElement(int[,] matrix)
        {
            int count = 1, resCount = 1;
            int rowIndexLongestSeries = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        count++;
                        if (count > resCount)
                        {
                            resCount = count;
                            rowIndexLongestSeries = i;
                        }
                    }
                    else count = 1;
                }
                count = 1;
            }
            if (rowIndexLongestSeries >= 0) return $"Номер рядка, в якому знаходиться найдовша серія однакових елементів = {rowIndexLongestSeries}";
            else return "Не існує рядка з серією елементів";
        }
        public static string ProductElementsNotHaveNegativeElements(int[,] matrix)
        {
            int prod = 1;
            bool n = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                n = true;
                int tempProd = 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tempProd *= matrix[i, j];
                    if (matrix[i, j] < 0)
                    {
                        n = false;
                        break;
                    }
                }
                if (n) prod *= tempProd;
            }
            if (prod == 1) return "В кожному рядку матриці присутній від'ємний елемент, спробуйте згенерувати іншу матрицю\n";
            else return $"Добуток елементів в тих рядках, які не містять від’ємних елементів = {prod}\n";
        }
        public static int MaxSumDiagonal(int[,] matrix)
        {
            int sum = 0, max = int.MinValue;
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                int a = j;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                    j++;
                    if (j == matrix.GetLength(1)) break;
                }
                j = a;
                if (max < sum) max = sum;
                sum = 0;
            }


            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                int a = i;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                    i++;
                    if (i == matrix.GetLength(0)) break;
                }
                i = a;
                if (max < sum) max = sum;
                sum = 0;
            }


            return max;
        }
    }
}