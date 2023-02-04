using System;

public class Program
{
    public static void Main()
    {
        string[] characters = { "Wizard", "Dwarf", "Human", "Rogue", "Druid", "Robot", "Elf", "Monk" };
        string[] partyMembers = new string[5];

        foreach (string i in characters)
        {
            Console.WriteLine("Would you like the " + i + " to join your party?");
            string playerAnswer = Console.ReadLine();

            if (playerAnswer == "yes")
            {
                Console.WriteLine(i + " has joined your party.");
            }
            if (playerAnswer == "no")
            {
                Console.WriteLine(i + " was not added to your party.");
            }
            /*			if (partyMembers.Length > 5) {
                            Console.WriteLine("Your party is full. Only five members can be in your party.");
                            Console.WriteLine("Your party consists of:");
                                foreach(string d in partyMembers) {
                                    Console.WriteLine(d); */
            // code to track the party size and make sure it doesn't exceed 5, but i can't add things to the array right now, so it's useless.
        }
    }
}




