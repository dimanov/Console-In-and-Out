/*
 * Problem 7. Sum of 5 Numbers
 * Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 numbers, separated by a space:");
        string numbers = Console.ReadLine();
        float[] splitNumbers = new float[5];
        float sum = 0.0F;

        for (int index = 0; index < 5; index++)
        {
            splitNumbers[index] = float.Parse(numbers.Split(' ')[index]);
            sum = sum + splitNumbers[index];
        }
        Console.WriteLine("The sum of the 5 numbers is: {0:F2}", sum);
    }
}