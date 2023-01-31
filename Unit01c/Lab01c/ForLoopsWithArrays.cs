using System;

public class Program
{
    public static void Main()
    {
        string[] weapons = { "Sword", "Hammer", "Staff", "Wand", "Hands" };
        string[] heroName = { "Fighter", "Barbarian", "Rogue", "Wizard" };
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("You have chosen to be a Fighter.");
            Console.WriteLine("You have equipped a " + weapons[0] + ".");
        }
        for (int i = 1; i < 2; i++)
        {
            Console.WriteLine("You have chosen to be a Barbarian.");
            Console.WriteLine("You have equipped a " + weapons[1] + ".");
        }
        for (int i = 2; i < 3; i++)
        {
            Console.WriteLine("You have chosen to be a Rogue.");
            Console.WriteLine("You have equipped a " + weapons[2] + ".");
        }
        for (int i = 3; i < 4; i++)
        {
            Console.WriteLine("You have chosen to be a Wizard.");
            Console.WriteLine("You have equipped a " + weapons[3] + ".");
        }
    }

}

