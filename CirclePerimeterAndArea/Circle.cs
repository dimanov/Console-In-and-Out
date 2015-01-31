/*
 * Problem 3. Circle Perimeter and Area
 * Write a program that reads the radius  r  of a circle and prints its perimeter and area formatted with  2  digits after the decimal point.
 */

using System;


class Circle
{
    static void Main()
    {
        Console.Write("Please enter the radius of the circle: \nR=");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("Perimeter \t Area");
        Console.WriteLine("{0,9:F2} \t {1:F2}", perimeter, area);
    }
}