/*
 * Problem 8. Numbers from 1 to n
 * Write a program that reads an integer number  n  from the console and prints all the numbers in the interval  [1..n] , each on a single line.
 */

using System;

class NNumbers
{
    static void Main()
    {
        Console.Write("Please enter an integer number: \nn=");
        int n = int.Parse(Console.ReadLine());
        for (int index = 1; index <= n; index++)
        {
            Console.WriteLine(index);
        }
    }
}