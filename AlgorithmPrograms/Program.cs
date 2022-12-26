using System;

public class InsertionSort
{
    public static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ');

        // Insertion Sort Algorithm
        for (int i = 1; i < words.Length; i++)
        {
            string key = words[i];
            int j = i - 1;

            while (j >= 0 && words[j].CompareTo(key) > 0)
            {
                words[j + 1] = words[j];
                j = j - 1;
            }

            words[j + 1] = key;
        }

        // Print the sorted list
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}