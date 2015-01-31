/*
 * Problem 9. Sum of n Numbers
 * Write a program that enters a number  n  and after that enters more  n  numbers and calculates and prints their  sum . 
 * Note: You may need to use a for-loop. 
 */

using System;

class SumNNumber
{
    static void Main()
    {
        Console.Write("Please enter how many numbers will you enter: \nn=");
        int n = int.Parse(Console.ReadLine());
        float[] Numbers = new float[n];
        float sum = 0.0F;
        for (int index = 0; index < n; index++)
        {
            Numbers[index] = float.Parse(Console.ReadLine());
            sum = sum + Numbers[index];
        }
        Console.WriteLine("The sum of the {0} numbers is: {1:F2}", n, sum);
    }
}