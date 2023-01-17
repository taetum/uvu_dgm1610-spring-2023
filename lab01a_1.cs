//the program keeps saying i don't have a static main method, but idk how to fix it
using System;

public class Program
{
    public Dagger thiefsDagger;
    public Sword masterSword;

    public void Main()
    {
        thiefsDagger = new Dagger();
        masterSword = new Sword();
        Console.WriteLine("You have dropped the " + thiefsDagger.daggerName + ".");
        Console.WriteLine("You have picked up the " + masterSword.swordName + ". Your attack speed has increased from " + thiefsDagger.attackSpeed + " to " + masterSword.attackSpeed + ".");
        Console.WriteLine("Use this sacred blade wisely.");
    }

    public class Sword
    {
        public string swordName = "Master Sword";
        public int swordDamage = 10;
        public float attackSpeed = 1.5f;

    }

    public class Dagger
    {
        public string daggerName = "Thief's Dagger";
        public int daggerDamage = 2;
        public float attackSpeed = 0.8f;

    }
}
