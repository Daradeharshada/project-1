// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public static class StringExtensions
{
    public static bool IsPalindrome(this string s)
    {
        if (string.IsNullOrEmpty(s))
            return true;

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }
        return true;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("madam".IsPalindrome());  // True
        Console.WriteLine("ooo".IsPalindrome());  // False
    }
}
