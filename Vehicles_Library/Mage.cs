using System;
using System.Collections.Generic;
using System.Text;
using Characters.Interfaces;

namespace Characters
{
    public class Mage : Character, IMage
    {
        public int Mana { get; private set; } = 50;
        public int MagicStrength { get; private set; } = 10;

        public void SetMana(int mana)
        {
            Mana = mana;
        }

        public void SetMagicStrength(int magicStrength)
        {
            MagicStrength = magicStrength;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} cast a spell!");
        }

        public override void Defend()
        {
            Console.WriteLine($"{Name} put up a magic barrier!");
        }

        public Mage() {}

        public Mage(int mana)
        {
            Mana = mana;
        }

        public Mage(int mana, int magicStrength)
        {
            Mana = mana;
            MagicStrength = magicStrength;
        }
    }
}
