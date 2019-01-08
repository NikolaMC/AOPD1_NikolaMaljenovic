using System;
using System.Collections.Generic;
using System.Text;

namespace Characters.Interfaces
{
    // This interface contains the 2 properties that both the enemy mage and the player's character must have as a mage

    interface IMage
    {
        int MagicStrength { get; }
        int Mana { get; }
    }
}
