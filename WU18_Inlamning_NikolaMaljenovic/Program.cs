using System;
using Characters;

namespace WU18_Inlamning_NikolaMaljenovic
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("\nWhat character class would you like to pick?\n");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Warrior");
                Console.WriteLine("2. Mage");
                Console.WriteLine("3. Ranger");

                int classChoice = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                if (classChoice == 0)
                {
                    Environment.Exit(0); 
                }
                else if (3 < classChoice) 
                {
                    InvalidInput();
                    continue;
                }

                CharacterClasses userClassChoice = (CharacterClasses)classChoice;

                Character character = Factory.GetCharacter(userClassChoice);

                Console.WriteLine("\nWhat would you like to name your character?");
                string characterName = Console.ReadLine();
                character.SetName(characterName);

                Console.Clear();

                Console.WriteLine($"You successfully named your character {character.Name}!\n");

                while (true)
                {
                    Console.WriteLine($"{character.Name}\nClass: {userClassChoice}\nHealth: {character.Health}\nLevel: {character.Level}\n");



                    Console.WriteLine("What would you like to do?\n");
                    Console.WriteLine("0. Pick an another character class");
                    Console.WriteLine("1. Fight an enemy");

                    int secondChoice = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                    if (secondChoice == 0)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (secondChoice == 1)
                    {
                        Console.Clear();
                        int randomEnemyId = EnemyClassIdGenerator.GenerateRandomEnemyClassId();
                        CharacterClasses enemyId = (CharacterClasses)randomEnemyId;
                        Character enemyCharacter = Factory.GetEnemyCharacter(enemyId);

                        while (true)
                        {
                            Console.WriteLine("What would you like to do?\n");
                            Console.WriteLine("0. Flee");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Defend");
                            Console.WriteLine("3. Level up");

                            int actionChoice = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                            if (actionChoice == 0)
                            {
                                Console.Clear();
                                character.Flee();
                                break;
                            }
                            else if (actionChoice == 1)
                            {
                                Console.Clear();
                                character.Attack();
                                enemyCharacter.Defend();
                            }
                            else if (actionChoice == 2)
                            {
                                Console.Clear();
                                character.Defend();
                                enemyCharacter.Attack();
                            }
                            else if (actionChoice == 3)
                            {
                                Console.Clear();
                                Console.WriteLine($"How many levels do you want {character.Name} to gain?");
                                int userLevelUpInput = int.Parse(Console.ReadLine());
                                Console.Clear();
                                character.LevelUp(userLevelUpInput);
                            }
                            else
                            {
                                InvalidInput();
                                continue;
                            }
                        }
                    }
                    else
                    {
                        InvalidInput();
                        continue;
                    }
                }
            }

            
        }

        static void InvalidInput()
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid option.\n");
        }
    }
}
