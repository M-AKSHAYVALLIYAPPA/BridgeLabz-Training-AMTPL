using System;
public class BubbleSort
{
    public static int[] Bubbles(int[] unsortedarr)
    {
        int temp;
        for(int i = 0; i < unsortedarr.Length - 1; i++)
        {
            for(int j = 0; j < unsortedarr.Length - (i+1); j++)
            {
                if (unsortedarr[j] > unsortedarr[j + 1])
                {
                    temp = unsortedarr[j + 1];
                    unsortedarr[j + 1] = unsortedarr[j];
                    unsortedarr[j] = temp;
                }
            }
        }
        return unsortedarr;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Array Elements: ");
        string[] parts = Console.ReadLine().Split(',');
        int[] unsortedarr = Array.ConvertAll(parts, int.Parse);
        int[] sortedarr = Bubbles(unsortedarr);
        Console.WriteLine("Sorted Array List: " + string.Join(",", sortedarr));
    }
}