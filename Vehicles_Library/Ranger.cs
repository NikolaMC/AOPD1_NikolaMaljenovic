using System;
using System.Collections.Generic;
using System.Text;
using Characters.Interfaces;

namespace Characters
{
    class Ranger : Character, IRanger
    {
        public int Speed { get; private set; } = 10;
        public int BowDamage { get; set; } = 15;

        public void SetBowDamage(int bowDamage)
        {
            BowDamage = bowDamage;
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} fired an arrow!");
        }

        public override void Defend()
        {
            Console.WriteLine($"{Name} evaded!");
        }

        public Ranger() { }

        public Ranger(int bowDamage)
        {
            BowDamage = bowDamage;
        }

        public Ranger(int bowDamage, int speed)
        {
            BowDamage = bowDamage;
            Speed = speed;
        }
    }
}
