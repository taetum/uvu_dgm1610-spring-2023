using System;

public class Program
{
    public Monster firstMonster;
    public player playerCharacter;

    public void Main()
    {
        firstMonster = new Monster();
        playerCharacter = new player();
        Console.WriteLine("Enter your name.");
        string playerName = Console.ReadLine();
        Console.WriteLine("A monster appears before you.");
        do
        {
            Console.WriteLine("Do you attack or Defend?");
            string playerChoice = Console.ReadLine();

            if (playerChoice == "Attack")
            {
                firstMonster.monsterHealth -= playerCharacter.playerAttack;
                Console.WriteLine(playerName + " has attacked. The monster loses 4 health.");
            }

            if (playerChoice == "Defend")
            {
                Console.WriteLine(playerName + " defends. The monster also just stands there.");
                Console.WriteLine("I don't know how to code the monster attacking, so you should really just keep hitting it. It's not going to do anything.");
            }
        }
        while (firstMonster.monsterHealth > 0);
        if (firstMonster.monsterHealth <= 0)
        {
            Console.WriteLine(playerName + " has slain the monster. Congratulations.");
        }

    }


     public class Monster
    {
        public int monsterHealth = 10;
        public int monsterAttack = 2;
    }
    public class player
    {
        public string playerName;
        public int playerHealth = 5;
        public int playerAttack = 4;
    }
}