// See https://aka.ms/new-console-template for more information
using AlgorithmProblem;

class Program
{
    public static void Main(string[] args)
    {
        {
            {
                int[] arr = { 52, 4, 300, 21, 102 };

                Console.WriteLine("Array before sorting:");
                Sorting.PrintArray(arr);

                Sorting.MergeSort(arr, 0, arr.Length - 1);

                Console.WriteLine("\nArray after sorting:");
                Sorting.PrintArray(arr);
            }
        }
    }
}