using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_15
{
    internal class Program
    {
        static void Main()
        {
        
                int[] array = GenerateRandomArray(10);

                Console.WriteLine("Original Array:");
                PrintArray(array);

                BubbleSortDescending(array);

                Console.WriteLine("\nSorted Array:");
                PrintArray(array);

                Console.WriteLine("\nIs the array sorted correctly? " + IsSorted(array));

                Console.Write("\n enter the value to search in sorted array: ");
                int searchValue = Convert.ToInt32(Console.ReadLine());
                int searchIndex = BinarySearch(array, searchValue);

                if (searchIndex != -1)
                    Console.WriteLine($"\n{searchValue} found at index {searchIndex}.");
                else
                    Console.WriteLine($"\n{searchValue} not found in the array.");

            Console.ReadKey();
            }

            static int[] GenerateRandomArray(int size)
            {
                Random rand = new Random();
                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next(1, 101); 
                }

                return array;
            }

            static void BubbleSortDescending(int[] array)
            {
                int n = array.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                          
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            static bool IsSorted(int[] array)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] < array[i])
                        return false;
                }

                return true;
            }

            static int BinarySearch(int[] array, int target)
            {
                int left = 0;
                int right = array.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (array[mid] == target)
                        return mid;

                    if (array[mid] < target)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }

                return -1; 
            }

            static void PrintArray(int[] array)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            

            }
        }
    }

