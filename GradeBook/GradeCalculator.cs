using System;

public class CalculateGrade
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your score:");
        int score;

        if (!int.TryParse(Console.ReadLine(), out score))
        {
            Console.WriteLine("Invalid input. Please enter a valid score.");
            return;
        }

        if (score >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (score >= 80 && score < 90)
        {
            Console.WriteLine("You have a B");
        }
        else if (score >= 70 && score < 80)
        {
            Console.WriteLine("You have a C");
        }
        else if (score >= 60 && score < 70)
        {
            Console.WriteLine("You have a D");
        }
        else
        {
            Console.WriteLine("You have an F");
        }
    }
}
