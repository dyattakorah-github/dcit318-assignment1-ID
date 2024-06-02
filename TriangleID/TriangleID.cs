using System;

public class TriangleID
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the three sides of a triangle: ");

        double side_1 = double.Parse(Console.ReadLine());
        double side_2 = double.Parse(Console.ReadLine());
        double side_3 = double.Parse(Console.ReadLine());

        if (side_1 == side_2 && side_2 == side_3)
        {
            Console.WriteLine("The triangle is Equilateral: All sides are equal.");
        }
        else if (side_1 == side_2 || side_1 == side_3 || side_2 == side_3)
        {
            Console.WriteLine("The triangle is Isosceles: Two sides are equal.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene: It has unequal sides.");
        }
    }
}
