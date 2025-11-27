using System;

public class Program
{
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements in an array: ");
        string[] parts = Console.ReadLine().Split(",");
        int[] arr = Array.ConvertAll(parts, int.Parse);

        Console.WriteLine("Enter the Target Element: ");
        int target = int.Parse(Console.ReadLine());

        int index = LinearSearch(arr, target);

        if (index != -1)
        {
            Console.WriteLine("The target element " + target + " was found at index " + index);
        }
        else
        {
            Console.WriteLine("The target element " + target + " was not found");
        }
    }
}
