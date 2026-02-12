// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Logger
{
    public static void Log(string message, params object[] args)
    {
        Console.WriteLine($"Log: {string.Format(message, args)}");
    }

    public static void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }

    public static void Log(object obj)
    {
        Console.WriteLine($"Log: {obj}");
    }
}

public class Program
{
    public static void Main()
    {
        Logger.Log("Hello, {0}!", "World");  // Works fine
        Logger.Log("Hello, World!");  // Works fine
        Logger.Log((object)"Hello, World!");  // Works fine
        Logger.Log(obj: "Hello, World!");  // Ambiguity error
        Logger.Log(message: "Hello, World!");  // Ambiguity error
    }
}