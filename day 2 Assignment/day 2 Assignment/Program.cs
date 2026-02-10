using System;

namespace day_2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 42;
            long big = 3_000_000_000L;
            float f = 3.14f;
            double d = 2.71828;
            decimal money = 19.99m;
            bool ok = true;
            char letter = 'A';

            Console.WriteLine("Integer value: " + a);
            Console.WriteLine("Long value: " + big);
            Console.WriteLine("Float value: " + f);
            Console.WriteLine("Double value: " + d);
            Console.WriteLine("Decimal value: " + money);
            Console.WriteLine("Boolean value: " + ok);
            Console.WriteLine("Character value: " + letter);

            //Console.ReadLine(); keeps console open
        }
    }
}
