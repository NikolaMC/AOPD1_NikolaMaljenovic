using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    public class Factory
    {
        // I used Enum here to determine what class the player's character should be based on user input and also 
        // to randomly generate class of the enemy character. The reason for that is because it increases the readability of the
        // switch statements. You can see the name of the character class instead of it being 1, 2, 3 etc.

        public static Character GetCharacter(CharacterClasses selectedClass)  
        {
            Character retChar = null;

            switch (selectedClass)
            {
                case CharacterClasses.Warrior:
                    retChar = new Warrior();
                    break;

                case CharacterClasses.Mage:
                    retChar = new Mage();
                    break;

                case CharacterClasses.Ranger:
                    retChar = new Ranger();
                    break;

                default:
                    break;
            }

            return retChar;
        }

        public static Character GetEnemyCharacter(CharacterClasses classId)
        {
            Character retEnemyChar = null;

            switch (classId)
            {
                case CharacterClasses.Warrior:
                    retEnemyChar = new EnemyWarrior();
                    Console.WriteLine("An enemy warrior appears!\n");
                    break;

                case CharacterClasses.Mage:
                    retEnemyChar = new EnemyMage();
                    Console.WriteLine("An enemy mage appears!\n");
                    break;

                case CharacterClasses.Ranger:
                    retEnemyChar = new EnemyRanger();
                    Console.WriteLine("An enemy ranger appears!\n");
                    break;

                default:
                    break;
            }

            return retEnemyChar;
        }
    }
}