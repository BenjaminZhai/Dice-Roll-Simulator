// Dice Roll Simulator
#nullable disable
Console.Clear();
string option = "";
showmenufunc();
Random dice = new Random();
bool loop = true;

// MENU

while (loop == true)
{


    if (option == "1")
    {
        for (int n = 1; n <= 1; n++)
        {
            int dice1 = dice.Next(1, 7);
            int dice2 = dice.Next(1, 7);

            Console.WriteLine($"{dice1},{dice2} Sum:{dice1 + dice2}");
        }
        showmenufunc();
    }
    else if (option == "2")
    {
        for (int n = 1; n <= 5; n++)
        {
            int dice1 = dice.Next(1, 7);
            int dice2 = dice.Next(1, 7);

            Console.WriteLine($"{dice1},{dice2} Sum:{dice1 + dice2}");
        }
        showmenufunc();
    }
    else if (option == "3")
    {
        Console.WriteLine("How many rolls would you like?");
        int amount = Convert.ToInt32(Console.ReadLine());
        for (int n = 1; n <= amount; n++)
        {
            int dice1 = dice.Next(1, 7);
            int dice2 = dice.Next(1, 7);

            Console.WriteLine($"{dice1},{dice2} Sum:{dice1 + dice2}");
        }
        showmenufunc();
    }
    else if (option == "4")
    {
        int snakeeyes = 0;
        for (int n = 1; n != -1; n++)
        {
            int dice1 = dice.Next(1, 7);
            int dice2 = dice.Next(1, 7);
            Console.WriteLine($"{dice1},{dice2} Sum:{dice1 + dice2}");
            snakeeyes++;
            if (dice1 + dice2 == 2)
            {
                if (snakeeyes == 1)
                {
                    Console.WriteLine($"It took {snakeeyes} try to reach snake eyes!");
                    break;
                }
                else
                {
                    Console.WriteLine($"It took {snakeeyes} tries to reach snake eyes!");
                    break;
                }

            }
        }
        showmenufunc();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\nGOODBYE!");
        loop = false;
    }
}

void showmenufunc()
{
    Console.WriteLine("\nDice Roll Simulator Menu");
    Console.WriteLine("\n1. Roll Dice Once");
    Console.WriteLine("\n2. Roll Dice 5 Times");
    Console.WriteLine("\n3. Roll Dice 'n' Times");
    Console.WriteLine("\n4. Roll Dice Until Snake Eyes");
    Console.WriteLine("\n5. EXIT");
    Console.Write("Select an option (1-5): ");
    option = Console.ReadLine();
}