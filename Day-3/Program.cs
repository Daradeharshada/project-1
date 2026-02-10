// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static bool TryFindMax(int[] numbers, out int max)
    {
        if (numbers == null || numbers.Length == 0)
        {
            max = default;
            return false;
        }

        max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
                max = num;
        }
        return true;
    }

    public static (bool Found, int Max) FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return (false, default);

        var max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
                max = num;
        }
        return (true, max);
    }

    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5,6 };

        if (TryFindMax(numbers, out int max))
            Console.WriteLine($"Max: {max}");
        else
            Console.WriteLine("No max found.");

        var result = FindMax(numbers);
        if (result.Found)
            Console.WriteLine($"Max: {result.Max}");
        else
            Console.WriteLine("No max found.");
    }
}
