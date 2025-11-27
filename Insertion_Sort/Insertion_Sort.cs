using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 5, 2, 9, 1, 5, 6 };

        Console.WriteLine("Before Sorting:");
        PrintArray(arr);

        InsertionSort(arr);

        Console.WriteLine("After Sorting:");
        PrintArray(arr);
    }

    public static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];      
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }

    
    public static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
