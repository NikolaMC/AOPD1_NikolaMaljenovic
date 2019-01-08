using System;
using System.Collections.Generic;
using System.Text;

namespace Characters.Interfaces
{
    // This interface contains the 2 properties that both the enemy warrior and the player's character must have as a warrior
    interface IWarrior
    {
        int PhysicalStrength { get; }
        int Armor { get; }
    }
}
