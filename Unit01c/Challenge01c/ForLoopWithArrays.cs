using System;

public class Program
{
    public static void Main()
    {
        int[] favoriteNumbers = new int[5];
        Console.WriteLine("Type in five random numbers.");
        favoriteNumbers[0] = Convert.ToInt32(Console.ReadLine());
        favoriteNumbers[1] = Convert.ToInt32(Console.ReadLine());
        favoriteNumbers[2] = Convert.ToInt32(Console.ReadLine());
        favoriteNumbers[3] = Convert.ToInt32(Console.ReadLine());
        favoriteNumbers[4] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type in a number from 0 to four.");
        int luckyNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have chosen: ");
        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }
        Console.WriteLine("Your lucky number for today is ");
        Console.WriteLine(favoriteNumbers[luckyNumber]);
    }
}