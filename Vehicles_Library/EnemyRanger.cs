using System;
using System.Collections.Generic;
using System.Text;
using Characters.Interfaces;

namespace Characters
{
    class EnemyRanger : Character, IRanger
    {
        public int BowDamage { get; private set; } = 17;
        public int Speed { get; private set; } = 8;

        public EnemyRanger()
        {
            Name = "Enemy ranger";
        }
    }
}
