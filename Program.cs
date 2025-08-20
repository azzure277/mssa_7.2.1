using System;

namespace mssa_7._2._1
{
    internal class ShellSort
    {
        /* An utility function to 
           print array of size n*/
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        /* function to sort arr using shellSort */
        public void sort(int[] arr)
        {
            int n = arr.Length;

            // Start with a big gap, 
            // then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 54, 2, 3 };
            Console.Write("Array before sorting :\n");
            ShellSort.printArray(arr);

            ShellSort ob = new ShellSort();
            ob.sort(arr);

            Console.Write("Array after sorting :\n");
            ShellSort.printArray(arr);
        }
    }
}
