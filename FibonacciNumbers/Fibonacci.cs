/*
 * Problem 10. Fibonacci Numbers
 * Write a program that reads a number  n  and prints on the console the first  n  members of the Fibonacci sequence 
 * (at a single line, separated by comma and space -  , ) :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .
 */

using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Please enter how many members of the Fibonacci sequence would you like to get: \nn=");
        ulong n = ulong.Parse(Console.ReadLine());
        ulong a = 0;
        ulong b = 1;
        Console.Write("{0} ", a);
        for (ulong index = 1; index < n; index++)
        {
            a = a + b;
            b = a - b;
            Console.Write("{0} ", a);
        }
        Console.WriteLine();
    }
}