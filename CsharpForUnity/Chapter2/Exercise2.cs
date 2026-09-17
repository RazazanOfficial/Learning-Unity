/*
Exercise 2 - Character Creator

Ask the player to enter:

- Player name
- Character class

The available classes are:

Warrior
Mage
Rogue

Create these stats:

- health
- mana
- damage

Set their values depending on the selected class:

Warrior:
- Health: 150
- Mana: 30
- Damage: 25

Mage:
- Health: 80
- Mana: 150
- Damage: 40

Rogue:
- Health: 100
- Mana: 60
- Damage: 35

Use a switch statement to determine the stats.

If the player enters an invalid class,
print an error message.

If the class is valid, print:

- Player name
- Character class
- Health
- Mana
- Damage
*/
static class Exercise2
{
    public static void Run()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter your character class: ");
        string characterClass = Console.ReadLine();

        int health = 0;
        int mana = 0;
        int damage = 0;

        switch (characterClass)
        {
            case "warrior":
                health = 150;
                mana = 30;
                damage = 25;
                break;
            case "mage":
                health = 80;
                mana = 150;
                damage = 40;
                break;
            case "dexterity":
                health = 100;
                mana = 60;
                damage = 35;
                break;
            default:
                Console.WriteLine("Class is invalid...");
                return;
        }
        Console.Write($"Name: {name} | Character Class: {characterClass} |  Health: {health} | Mana: {mana} | Damage: {damage}");
    }
}