// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        Console.WriteLine(p1);

        Person p2 = new Person("Harshada", 20);
        Console.WriteLine(p2);

        Person p3 = new Person("Alex", -5);
        Console.WriteLine(p3);

        Console.ReadLine();
    }
}

