using System;
public class BinarySearch
{
    public static int FirstOccurence(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        int result = -1;
        while(low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                high = mid - 1;
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return result;
    }
    public static int LastOccurence(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        int result = -1;
        while(low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                low = mid + 1;
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return result;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements: ");
        string[] parts = Console.ReadLine().Split(',');
        int[] arr = Array.ConvertAll(parts, int.Parse);
        Array.Sort(arr);
        Console.WriteLine("Sorted Element List: " + string.Join(" ", arr));
        Console.WriteLine("Enter the Target Element: ");
        int target = int.Parse(Console.ReadLine());

        int first = FirstOccurence(arr, target);
        int last = LastOccurence(arr, target);

        if(first != -1)
        {
            Console.WriteLine("The First Occurence of the Target element is at: " + first);
        }
        if(last != -1)
        {
            Console.WriteLine("The Last Occurence of the Target Element is at: " + last);
        }
        if(first != -1 && last != -1)
        {
            Console.WriteLine($"The First and Last Occurence is: [{first}, {last}]");
            Console.WriteLine("The Number of Occurences is:  " + ((last - first) + 1));
        }
        else
        {
            Console.WriteLine("The target element does not exists: ");
            Console.WriteLine("First and Last Occureneces: [-1,-1]");
        }

    }
}