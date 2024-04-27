using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int CountOccurrences(int[] arr, int key)
        {
            int firstIndex = FirstIndex(arr, key);
            int lastIndex = LastIndex(arr, key);

            if (firstIndex == -1 || lastIndex == -1)
                return 0;

            return lastIndex - firstIndex + 1;
        }

        static int FirstIndex(int[] arr, int key)
        {
            int low = 0, high = arr.Length - 1, firstIndex = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == key)
                {
                    firstIndex = mid;
                    high = mid - 1;
                }
                else if (arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return firstIndex;
        }

        static int LastIndex(int[] arr, int key)
        {
            int low = 0, high = arr.Length - 1, lastIndex = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == key)
                {
                    lastIndex = mid;
                    low = mid + 1;
                }
                else if (arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return lastIndex;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 9, 10 };
            int key = 2;
            int count = CountOccurrences(array, key);
            Console.WriteLine($"Кількість входжень числа {key} у масиві: {count}");
            Console.ReadKey();
        }
    }
}
