/*
Exercise 1 - Dungeon Entrance

Ask the player to enter:

- Player name
- Player level
- Current health
- Current gold
- Whether they have the dungeon key ("yes" or "no")

Dungeon requirements:

- The player must be at least level 5.
- The player must have more than 0 health.
- The player must have the dungeon key.
- Entering the dungeon costs 100 gold.

Rules:

1. If the player's health is 0 or less,
   print that the player is dead and cannot enter.

2. Otherwise, if the player's level is below 5,
   print that their level is too low.

3. Otherwise, if they do not have the key,
   print that the dungeon key is required.

4. Otherwise, if they have less than 100 gold,
   print that they do not have enough gold.

5. Otherwise:
   - Subtract 100 gold.
   - Print that the player entered the dungeon.
   - Print their remaining gold.

Use if, else if, and else.
*/

static class Exercise1
{
    public static void Run()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("What is your level? ");
        int level = Convert.ToInt32(Console.ReadLine());

        Console.Write("How much health do you have? ");
        int health = Convert.ToInt32(Console.ReadLine());

        Console.Write("How much gold do you have? ");
        int gold = Convert.ToInt32(Console.ReadLine());

        Console.Write("Do you have the dungeon key? (yes/no): ");
        string keyInput = Console.ReadLine();

        if (health <= 0)
        {
            Console.WriteLine("Player is dead and cannot enter...");
        }
        else if (level < 5)
        {
            Console.WriteLine("Your level is too low...");
        }
        else if (keyInput != "yes")
        {
            Console.WriteLine("The dungeon key is required...");
        }
        else if (gold < 100)
        {
            Console.WriteLine("You don't have enough gold...");
        }
        else
        {
            gold -= 100;
            Console.WriteLine($"{name}, you have entered the dungeon. Welcome! Your remaining gold is {gold}.");
        }
    }
}
