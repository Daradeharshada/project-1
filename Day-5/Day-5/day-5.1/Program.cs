using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    class Program
    {
        static void Main()
        {
            CollectionClassesDemo();
        }

        public static void CollectionClassesDemo()
        {
            // Initial capacity = 10
            List<int> marks = new List<int>(10);

            // Adding single elements
            marks.Add(1);
            marks.Add(2);
            Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");

            // Adding multiple elements
            marks.AddRange(new int[] { 3, 4, 5 });
            Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");

            marks.AddRange(new List<int> { 6, 7, 8 });
            Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");

            // This exceeds capacity (10 → 20)
            marks.AddRange(new int[] { 9, 10, 11 });
            Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");

            // Average
            double avg = marks.Average();
            Console.WriteLine($"Marks Avg: {avg}");
        }
    }
}
