/*
 * Problem 11.* Numbers in Interval Dividable by Given Number
 * Write a program that reads two positive integer numbers and prints how many numbers  p  exist between them such that the reminder of the division by  5  is  0 .
 */

using System;

class DividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number: \na=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter bigger positive integer number: \nb=");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please enter the dividor: \nd=");
        int d = int.Parse(Console.ReadLine());

        int p = 0;
        int index = a;
        while (index % d != 0)
        {
            index++;
        }

        while (index <= b)
        {
            bool check = (b - index) < d;
            Console.Write(check ? "{0}" : "{0}, ", index);
            index += d;
            p += 1;
        }
        Console.Write("\n");
        Console.WriteLine("Between {0} and {1} has {2} numbers devidable by {3}", a, b, p, d);

    }
}