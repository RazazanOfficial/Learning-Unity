/*
Exercise 2 - Shop Calculator

Ask the user to enter:

- Player name
- Current gold
- Item name
- Item price
- Quantity to buy

Calculate the total purchase price.

Then calculate how much gold the player will have
after buying the items.

Print a receipt containing:

- Player name
- Item name
- Stock Quantity
- Total price
- Remaining gold

Do not use if statements.
All values except the player name and item name
must be entered by the user at runtime.
*/

static class Exercise2
{
    public static void Run()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("How much is your current gold? ");
        int gold = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("What is that item name? ");
        string itemName = Console.ReadLine();
        
        Console.Write("How much quantity do you have? ");
        int stockQuantity = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("How much the item price? ");
        int itemPrice = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("How much quantity do you want to buy? ");
        int quantityToBuy = Convert.ToInt32(Console.ReadLine());

        int purchasePrice = itemPrice * quantityToBuy;
        gold -= purchasePrice;
        stockQuantity -= quantityToBuy;
        Console.WriteLine($"Player Name: {name} | Current Gold: {gold} | Item Purchased Name: {itemName} | stock Quantity: {stockQuantity} | Item Price: {itemPrice} | Total Cost: {purchasePrice} ");
    }
}