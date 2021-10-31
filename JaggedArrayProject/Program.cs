using System;
using JaggedArrayClassLibrary;
using static System.Console;

namespace JaggedArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[][]
            {
                new[] {1, 2, 3, 8, 9},
                new[] {9, -11, 12, -13},
                new[] {0},
                null,
                new[] {-15, 11}
            };

            PrintJeggedArray(array);

            JaggedArray.SortBy(array, JaggedArray.CompareRowSum);

            WriteLine("-----");
            PrintJeggedArray(array);

            ReadKey();
        }

        public static void PrintJeggedArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                WriteLine(string.Format("{{ {0} }}", array[i] == null ? "null" : string.Join(", ", array[i])));
            }
        }
    }
}