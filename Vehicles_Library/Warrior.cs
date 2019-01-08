using System;
using System.Collections.Generic;
using System.Text;
using Characters.Interfaces;

namespace Characters
{
    public class Warrior : Character, IWarrior
    {
        public int PhysicalStrength { get; private set; } = 12;
        public int Armor { get; private set; } = 15;

        public void SetPhysicalStrength(int strength)
        {
            PhysicalStrength = strength;
        }

        public void SetArmor(int armor)
        {
            Armor = armor;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacked with a sword!");
        }

        public override void Defend()
        {
            Console.WriteLine($"{Name} used a shield to defend!");
        }

        public Warrior() {}

        public Warrior(int strength)
        {
            PhysicalStrength = strength;
        }

        public Warrior(int strength, int armor)
        {
            PhysicalStrength = strength;
            Armor = armor;
        }
    }
}
