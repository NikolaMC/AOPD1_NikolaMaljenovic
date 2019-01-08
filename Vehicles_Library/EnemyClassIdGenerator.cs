using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    // Couldn't really come up with any better use for a Struct, so I used it to generate a random number and then use that
    // number to get one of the values from Enum in order to determine the class of the randomly generated enemy character.

    public struct EnemyClassIdGenerator
    {
        public static int GenerateRandomEnemyClassId()
        {
            Random randomEnemyClassId = new Random();
            return randomEnemyClassId.Next(1, 4);
        }
    }
}
