/*
 * Problem 6. Quadratic Equation
 * Write a program that reads the coefficients  a ,  b  and  c  of a quadratic equation ax2 + bx + c = 0 and solves it 
 * (prints its real roots).
 */

using System;

class Quadratic
{
    static void Main()
    {
        Console.Write("Please enter a floating-point number: a=");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter a floating-point number: b=");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Please enter a floating-point number: c=");
        float c = float.Parse(Console.ReadLine());

        float D = b * b - 4 * a * c;

        if (D >= 0)
        {
            double x1 = (-b - Math.Sqrt(D)) / (2 * a);
            double x2 = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1={0}; x2={1}", x1, x2);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}