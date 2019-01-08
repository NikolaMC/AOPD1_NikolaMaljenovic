using System;
using System.Collections.Generic;
using System.Text;
using Characters.Interfaces;

namespace Characters
{
    public class EnemyWarrior : Character, IWarrior
    {
        public int PhysicalStrength { get; private set; } = 10;
        public int Armor { get; private set; } = 17;

        public EnemyWarrior()
        {
            Name = "Enemy warrior";
        }
    }
}
