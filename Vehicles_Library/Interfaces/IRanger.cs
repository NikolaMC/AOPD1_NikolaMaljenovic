using System;
using System.Collections.Generic;
using System.Text;

namespace Characters.Interfaces
{
    // This interface contains the 2 properties that both the enemy ranger and the player's character must have as a ranger
    interface IRanger
    {
        int Speed { get; }
        int BowDamage { get; }
    }
}
