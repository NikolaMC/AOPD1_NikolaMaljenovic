using System;

namespace Characters
{
    public class Character
    {

        public string Name { get; protected set; }

        // All characters that inherit from this class are supposed to have 100 health and be level 0 when created, 
        // so I set the default values here instead of setting them inside of the constructor method.
        // Also, the values of health and level aren't supposed to be negative, which is why I didn't use the shorter declaration
        // of a property for those 2.

        private int health = 100;

        public int Health
        {
            get { return health; }
            protected set
            {
                if (value >= 0)
                {
                    health = value;
                }
            }
        }

        private int level = 0;

        public int Level
        {
            get { return level; }
            protected set
            {
                if (value >= 0)
                {
                    level = value; 
                }
            }
        }

        public void SetName(string name)
        {
            Name = name;
        }

        // The player isn't supposed to be able to set the health of a character, or the level through the console window. 
        // Level can be increased using LevelUp() instead. Both values can be changed from their default values directly 
        // in the code by using these 2 methods.

        public void SetLevel(int level)
        {
            Level = level;
        }

        public void SetHealth(int health)
        {
            Health = health;
        }

        // -------------------------------------------

        public virtual void Attack()
        {
            Console.WriteLine($"\n{Name} attacked!\n");
        }

        public virtual void Defend()
        {
            Console.WriteLine($"\n{Name} defended!\n");
        }

        public void Flee()
        {
            Console.WriteLine($"\n{Name} fled!\n");
        }

        public void LevelUp(int levelsGained)
        {
            Level += levelsGained;
            Health += Level;
            Console.WriteLine($"{Name} gained {levelsGained} levels and {levelsGained} more max health!\n{Name} is now level {Level} and has {Health} max health.\n");
        }

        public Character() {}

        public Character(string name)
        {
            Name = name;
        }

        public Character(int level)
        {
            Level = level;
        }

        public Character(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public Character(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
    }
}
