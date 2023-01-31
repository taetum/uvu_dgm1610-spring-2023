using System;

public class Program
{

    public ClassChoice playerClass;

    public EquipWeapons PlayerWeapon;

    public void Main()
    {
        playerClass = new ClassChoice();
        Console.WriteLine("Choose a Class: Fighter, Barbarian, Rogue, or Wizard.");
        string heroName = Console.ReadLine();
        playerClass.ChooseClass(heroName);
        PlayerWeapon = new EquipWeapons();
        PlayerWeapon.currentWeapon = EquipWeapons.Weapons.Dagger;
        PlayerWeapon.checkWeapon();
    }


    public class ClassChoice
    {
        public void ChooseClass(string heroName)
        {
            if (heroName == "Fighter")
            {
                Console.WriteLine("You have chosen to be a Fighter.");
            }
            else if (heroName == "Barbarian")
            {
                Console.WriteLine("You have chosen to be a Barbarian.");
            }
            else if (heroName == "Rogue")
            {
                Console.WriteLine("You have chosen to be a Rogue.");
            }
            else if (heroName == "Wizard")
            {
                Console.WriteLine("You have chosen to be a Wizard.");
            }

        }
    }

    public class EquipWeapons
    {
        public enum Weapons
        {
            Sword,
            Hammer,
            Dagger,
            Wand
        }

        // as of now, no matter what you type you can only equip a dagger. i was getting a bit too ambitious.

        public Weapons currentWeapon = Weapons.Sword;

        public void checkWeapon()
        {
            switch (currentWeapon)
            {
                case Weapons.Sword:
                    Console.WriteLine("You have equipped the sword.");
                    break;
                case Weapons.Hammer:
                    Console.WriteLine("You have equipped the hammer.");
                    break;
                case Weapons.Dagger:
                    Console.WriteLine("You have equipped the Dagger.");
                    break;
                case Weapons.Wand:
                    Console.WriteLine("You have equipped the Wand.");
                    break;
            }
        }

        public class FighterClass
        {
            public string heroName = "Fighter";
            public int Strength = 12;
            public int Defense = 6;
            public int Magic = 0;
        }

        public class BarbarianClass
        {
            public string heroName = "Barbarian";
            public int Strength = 9;
            public int Defense = 9;
            public int Magic = 0;
        }

        public class RogueClass
        {
            public string heroName = "Rogue";
            public int Strength = 6;
            public int Defense = 12;
            public int Magic = 3;
        }

        public class WizardClass
        {
            public string heroName = "Wizard";
            public int Strength = 2;
            public int Defense = 6;
            public int Magic = 12;
        }
    }


}











