using System;
using System.Collections.Generic;
using System.Text;
using Characters.Interfaces;

namespace Characters
{
    public class EnemyMage : Character, IMage
    {
        public int MagicStrength { get; private set; } = 8;
        public int Mana { get; private set; } = 60;

        public EnemyMage()
        {
            Name = "Enemy mage";
        }
    }
}
