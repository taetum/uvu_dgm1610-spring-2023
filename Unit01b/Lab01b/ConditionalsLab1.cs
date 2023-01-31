using System;

public class Program
{
    public Holder classHolder;
    public void Main()
    {
        classHolder = new Holder();
        Console.WriteLine("Insert username.");
        string username = Console.ReadLine();
        classHolder.CheckUsername(username);

    }

}

public class Holder
{

    public void CheckUsername(string username)
    {
        if (username == "tae")
        {
            Console.WriteLine("Awesome username. Very cool.");
        }
        else
        {
            Console.WriteLine("Terrible username. Very bad.");
        }
    }
}
