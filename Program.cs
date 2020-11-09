using System;
using System.Collections.Generic;

namespace first_program
{
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favouriteSpell)
        {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0;

            Count++;
        }

        public void CastSpell()
        {
            if (spellSlots >0)
            {
            Console.WriteLine(name + " casts " + favouriteSpell + "!");
            spellSlots--;
            experience += 0.3f;
            } else {
                Console.WriteLine(name + " is out of Spell Slots.");
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots!");
            spellSlots = 2;
        }

        public void Intro()
        {
            Console.WriteLine("Your name is " + name + ". Ever since you were a child your favourite spell has been " + favouriteSpell+ ".\nYou are starting this journey with " + spellSlots + " Spell Slots at your disposal. With wizard experience of " + experience + " points\n--------------");
        }

        public void companionIntro()
        {
            Console.WriteLine("Your Companion's name is " + name + ". His favourite spell is " + favouriteSpell+ "\nHe has " + spellSlots + " Spell Slots and wizard experience of " + experience + " points.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of your wizard: ");
            string x = Console.ReadLine();
            
            Console.Write("Enter your favourite spell: ");
            string y = Console.ReadLine();

            Wizard wizard1 = new Wizard(Convert.ToString(x), Convert.ToString(y));


            Wizard wizard2 = new Wizard("Parry Hotter", "Unexpecto Patronum");


            Console.WriteLine("\n" + Wizard.Count + " wizards have been created! \n--------------------");

            //player intro
            wizard1.Intro();
            //companion intro
            wizard2.companionIntro();

            //wizard 1 actions
            Console.WriteLine();

            wizard1.CastSpell();
            wizard1.CastSpell();
            wizard1.CastSpell();

            //wizard 2 actions
            wizard2.CastSpell();

            //stops the code
            Console.ReadKey();
        }

    }
}
