/*
 * Problem 1. Sum of 3 Numbers
 * Write a program that reads 3 real numbers from the console and prints their sum.
 */

using System;

class SumThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads 3 real numbers from the console and prints their sum");
        decimal[] myArray = new decimal[3];
        decimal sum = 0.0M;
        for (int index = 0; index < 3; index++)
        {
            Console.Write("Enter number{0} = ", index + 1);
            myArray[index] = decimal.Parse(Console.ReadLine());
            sum = sum + myArray[index];
        }
        Console.WriteLine("The sum of the entered numbers is: {0:#.##}", sum);
    }
}