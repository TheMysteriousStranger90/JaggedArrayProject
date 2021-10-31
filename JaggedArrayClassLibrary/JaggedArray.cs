using System;
using System.Linq;

namespace JaggedArrayClassLibrary
{
    public static class JaggedArray
    {
        public delegate int CompareRowsMethod(int[] arr1, int[] arr2);

        public static void SortBy(int[][] arr, CompareRowsMethod compRow)
        {
            CheckArrayToNull(arr);
            SortByMethod(arr, compRow);
        }

        private static void CheckArrayToNull(int[][] arr)
        {
            if (arr == null) throw new ArgumentNullException(nameof(arr));
        }

        private static void SortByMethod(int[][] array, CompareRowsMethod compRow)
        {
            for (int i = array.Length - 1; i > 0; i--)
            for (int j = 0; j < i; j++)
                if (compRow(array[j], array[j + 1]) > 0)
                    Swap(ref array[j], ref array[j + 1]);
        }

        public static void Swap(ref int[] arr1, ref int[] arr2)
        {
            var tmp = arr1;
            arr1 = arr2;
            arr2 = tmp;
        }

        public static int? CheckNull(int[] arr1, int[] arr2) =>
            arr1 == null && arr2 == null ? 0 :
            arr1 == null ? -1 :
            arr2 == null ? 1 : (int?) null;

        public static int CompareRowSum(int[] arr1, int[] arr2) =>
            CheckNull(arr1, arr2) ?? arr1.Sum().CompareTo(arr2.Sum());

        public static int CompareRowMax(int[] arr1, int[] arr2) =>
            CheckNull(arr1, arr2) ?? arr1.Max().CompareTo(arr2.Max());

        public static int CompareRowMin(int[] arr1, int[] arr2) =>
            CheckNull(arr1, arr2) ?? arr1.Min().CompareTo(arr2.Min());
    }
}