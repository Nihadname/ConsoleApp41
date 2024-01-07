// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int PlayerHp = 40;
int EnemyHp = 40;

int PLayerDamege = 7;
int EnemyDamege = 5;
int healing = 6;
Random random = new Random();

while (PlayerHp > 0 && EnemyHp > 0)
{
    Console.WriteLine("playerHp -" +PlayerHp + "emenyHp -" +EnemyHp);
    Console.WriteLine("player turn");
    Console.WriteLine("if you want to heal click h or attack a");
    char ourChoice;
    bool validInput = char.TryParse(Console.ReadLine(), out ourChoice);

    if (!validInput)
    {
        Console.WriteLine("Invalid input. Please enter 'h' for heal or 'a' for attack.");
        continue; // Restart the loop to re-prompt the user
    }

    if (ourChoice == 'h')
    {
        PlayerHp += healing;
        Console.WriteLine("player healed -" +healing);
    }else if(ourChoice == 'a')
    {
        PlayerHp -= EnemyDamege;
        Console.WriteLine("player is damaged ");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please choose 'h' to heal or 'a' to attack.");
        continue;
    }

    //enemy part
    Console.WriteLine("-- enemy part--");

    int randomincrease = random.Next(0, 2);
    if(randomincrease == 0)
    {
        EnemyHp -= PLayerDamege;
        Console.WriteLine("enemy is damaged");
    }else if(randomincrease == 1)
    {
        EnemyHp += healing;
        Console.WriteLine("enemy  healed -" + healing);
    }


    
    

}
if(PlayerHp > 0)
{
    Console.WriteLine("you have won");
}
else
{
    Console.WriteLine("you lose");
}