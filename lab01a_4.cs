using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01a_4
{
    internal class Program
    {
        public Person ted;
        public Potion evilBadPotion;

        public void Main(string[] args)
        {
            ted = new Person();
            evilBadPotion = new Potion();

            Console.WriteLine("Ted has drank the" + evilBadPotion.potionName + " His IQ has dropped from " + ted.iqLevel + " to " + (ted.iqLevel + evilBadPotion.iqReduction) + ".");
        }
    }
}

public class Person
{
    public int heightInches = 68;
    public string name = "Ted";
    public bool isTedNice = true;
    public int iqLevel = 110;

}

public class Potion
{
    public int iqReduction = -30;
    public string potionName = "Evil Bad Potion";
}
