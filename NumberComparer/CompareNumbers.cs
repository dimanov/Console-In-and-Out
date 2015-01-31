/*
 * Problem 4. Number Comparer
 * Write a program that gets two numbers from the console and prints the greater of them.
 * Try to implement this without if statements.
 */

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: a=");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: b=");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine("Greater is: {0}", (a + b + Math.Abs(a - b)) / 2);
        //Console.WriteLine("Smaller: {0}", (a + b - Math.Abs(a - b)) / 2);

        //int max = a - ((a - b) & ((a - b) >> 31));
        //Console.WriteLine("The greater number is: {0}", max);
    }
}