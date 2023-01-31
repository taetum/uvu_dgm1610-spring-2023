using System;

public class Program
{

    public static void Main()
    {

        Console.WriteLine("are you cool");
        string isCool = Console.ReadLine();
        while (isCool != "yes")
        {
            Console.WriteLine("you can't enter if you're not cool.");
            Console.WriteLine("try again.");
            return;
        }
        if (isCool == "yes")
        {
            Console.WriteLine("nice. you can come in");
        }

    }

    public class CoolVariable
    {
        public string isCool;
    }
}
