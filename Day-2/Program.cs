using System;
using System.Collections.Generic;

// Array example
int[] arr = { 10, 20, 30, 40, 50 };

// List example
var list = new List<string> { "Apple", "Banana", "Cherry" };

// 1️⃣ for loop
Console.WriteLine("FOR LOOP:");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

// 2️⃣ foreach loop
Console.WriteLine("\nFOREACH LOOP:");
foreach (var item in list)
{
    Console.WriteLine(item);
}

// 3️⃣ while loop
Console.WriteLine("\nWHILE LOOP:");
int iCounter = 0;
while (iCounter++ < 5)
{
    Console.WriteLine("iCounter = " + iCounter);
}
