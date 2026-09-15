/*
Exercise 1 - Character Stats

Create variables for a game character:

- name
- level
- health
- attackDamage
- armor
- gold

The character gets hit by an enemy.
The enemy deals 35 damage.

Armor reduces the received damage by 10.

Update the character's health after receiving the damage.

Then the character finds 50 gold.
Update the character's gold.

Finally, print the character's name, level, health, and gold.

Do not use if statements.
*/
static class Exercise1
{
    public static void Run()
    {
        string name = "Meraj";
        int level = 2;
        int health = 100;
        int attackDamage = 5;
        int armor = 100;
        int gold = 600;

        health = (health - attackDamage*7) + 10;
        gold += 50;

        Console.WriteLine($"Player Name is : {name} | Level : {level} | Health : {health} | Gold : {gold}");
    }
}