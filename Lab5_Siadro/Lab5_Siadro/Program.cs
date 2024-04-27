using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5_Siadro
{
    internal class Program
    {
        static void FillArrayRandom(int[] array, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
            }

            Console.WriteLine("\n Array A:");
            foreach (int i in array)
            {
                Console.Write(" {0}", i);
            }
        }

        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (int i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }
            return result;
        }

        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            int index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
        }

        static int BinarySearch(int[] array, int searchedValue)
        {
            int count = 0, i;
            int mid = 0, low = 0, high = array.Length;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (searchedValue == array[mid])
                {
                    count++;
                    
                    i = mid - 1;
                    while (i >= 0 && array[i] == searchedValue)
                    {
                        count++;
                        i--;
                    }

                    i = mid + 1;
                    while (i < array.Length && array[i] == searchedValue)
                    {
                        count++;
                        i++;
                    }

                    return count;
                }
                else if (searchedValue < array[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                } 
            }

            return 0;
        }

        static int LinearSerch(int[] array, int searchValue)
        {
            int count = 0;

            foreach (int i in array)
            {
                if (i == searchValue)
                    count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            int k = 18, n = Convert.ToInt32(20 + 0.6 * k);
            int[] arrayA = new int[n];

            FillArrayRandom(arrayA, n);

            Console.WriteLine("\n Ordered array:\n {0}", string.Join(" ", SelectionSort(arrayA)));
            
            Console.WriteLine("\n Binary search:");
            Console.Write(" Input num: ");

            int biSearchValue = Convert.ToInt32(Console.ReadLine());
            int binarySearch = BinarySearch(arrayA, biSearchValue);
            Console.WriteLine(" Count = {0}", binarySearch);

            Console.WriteLine("\n Linear Search:");
            Console.Write(" Input num: ");

            int liSearchValue = Convert.ToInt32(Console.ReadLine());
            int linearSearch = LinearSerch(arrayA, liSearchValue);
            Console.WriteLine(" Count = {0}", linearSearch);

            Console.ReadKey();
        }
    }
}
