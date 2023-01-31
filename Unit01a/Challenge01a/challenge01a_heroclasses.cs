using System;

public class Program
{
    public Hero heroOne;
    public Hero heroTwo;

    public Item magicPotion;
    public Item knightsArmor;
    public Item brassKnuckles;

    public void Main()
    {
        //heroes
        heroOne = new Hero();
        heroTwo = new Hero();

        heroOne.health = 5;
        heroOne.powerLevel = 5;
        heroOne.heroType = "Human";
        heroOne.magicLevel = 0;

        heroTwo.health = 2;
        heroTwo.powerLevel = 1;
        heroTwo.heroType = "Wizard";
        heroTwo.magicLevel = 5;

        //items

        magicPotion = new Item();
        knightsArmor = new Item();
        brassKnuckles = new Item();

        magicPotion.powerIncrease = 0;
        magicPotion.magicIncrease = 3;
        magicPotion.healthIncrease = 0;

        knightsArmor.powerIncrease = 0;
        knightsArmor.magicIncrease = 0;
        knightsArmor.healthIncrease = 3;

        brassKnuckles.powerIncrease = 3;
        brassKnuckles.magicIncrease = 0;
        brassKnuckles.healthIncrease = 0;


        Console.WriteLine("Your hero is a " + heroOne.heroType + ".");
        Console.WriteLine("They have " + heroOne.health + " health points.");
        Console.WriteLine("Their power level is " + heroOne.powerLevel + ".");
        Console.WriteLine("Their magic level is " + heroOne.magicLevel + ".");

        Console.WriteLine(" "); //line break
        Console.WriteLine("Your next hero is a " + heroTwo.heroType + ".");
        Console.WriteLine("They have " + heroTwo.health + " health points.");
        Console.WriteLine("Their power level is " + heroTwo.powerLevel + ".");
        Console.WriteLine("Their magic level is " + heroTwo.magicLevel + ".");

        Console.WriteLine(" "); //line break
        Console.WriteLine("You can only bring one item with you. Choose one.");
        Console.WriteLine("The magic potion grants you +" + magicPotion.magicIncrease + " magic power.");
        Console.WriteLine("The Knight's Armor grants you +" + knightsArmor.healthIncrease + " health points.");
        Console.WriteLine("The brass knuckles grant you +" + brassKnuckles.powerIncrease + " strength.");


    }
}

public class Hero
{
    public int health;
    public int powerLevel;
    public int magicLevel;
    public bool isHeroAlive = true;
    public string heroType = "Hero";
}

public class Item
{
    public int powerIncrease;
    public int magicIncrease;
    public int healthIncrease;
}
