using System;

public class Program
{
    public void Main()
    {
        string[] owner = { "Farmer", "Pet Owner", "Cat Lady", "Rider", "Old Lady At Park" };
        string[] animals = { "Cow", "Dog", "Cat", "Horse", "Duck" };

        foreach (string i in owner)
        {
            Console.WriteLine(i + "'s");
            for (int n = 0; n < 1; n++)
            {

                Console.WriteLine(animals[2]);
            }


            /*	foreach (string n in animals) {
			Console.WriteLine(animals[3]);
		} */

        }

    }
}

