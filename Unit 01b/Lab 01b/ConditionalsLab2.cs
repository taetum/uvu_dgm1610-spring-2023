using System;

public class Program
{
    public Equations GtLt;

    public void Main()
    {
        GtLt = new Equations();
        Console.WriteLine("Enter your first number.");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your second number.");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        GtLt.DoMath(numberOne, numberTwo);
    }
}

public class Equations
{
    public void DoMath(int numberOne, int numberTwo)
    {
        if (numberOne > numberTwo)
        {
            Console.WriteLine(numberOne + " is greater than " + numberTwo);
        }
        else if (numberOne < numberTwo)
        {
            Console.WriteLine(numberOne + " is less than " + numberTwo);
        }
        else if (numberOne == numberTwo)
        {
            Console.WriteLine("The two numbers are equal.");
        }
    }

}
