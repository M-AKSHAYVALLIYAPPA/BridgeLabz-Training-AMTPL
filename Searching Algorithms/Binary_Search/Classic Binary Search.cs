using System;
public class Program
{
    public static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        while(low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements in a sorted array: ");
        string[] parts = Console.ReadLine().Split(",");
        int[] arr = Array.ConvertAll(parts, int.Parse);
        Console.WriteLine("Enter the Target Element: ");
        int target = int.Parse(Console.ReadLine());
        int index = BinarySearch(arr, target);
        if(index != -1)
        {
            Console.WriteLine("the target element " + target + " was found at index " + index);
        }
        else
        {
            Console.WriteLine("The target element" + target + " was not found");
        }
    }
}