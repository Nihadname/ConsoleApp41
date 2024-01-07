// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int PlayerHp = 40;
int EnemyHp = 40;

int PLayerDamege = 7;
int EnemyDamege = 5;
int healing = 6;
while(PlayerHp > 0 && EnemyHp > 0)
{
    Console.WriteLine("playerHp -" +PlayerHp + "emenyHp -" +EnemyHp);
    Console.WriteLine("player turn");
    Console.WriteLine("if you want to heal click h or attack a");
    char ourChoice=char.Parse(Console.ReadLine());

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
        Console.WriteLine("you choose option that is existed");
        ourChoice= char.Parse(Console.ReadLine());
    }

    //enemy part
    Console.WriteLine("-- enemy part--");
    Random random = new Random();

    int randomincrease = random.Next(0, 3);
    if(randomincrease == 1)
    {
        EnemyHp -= PLayerDamege;
        Console.WriteLine("enemy is damaged");
    }else if(randomincrease == 2)
    {
        EnemyHp += healing;
        Console.WriteLine("enemy  healed -" + healing);
    }


    if (PlayerHp == 0)
    {

        Console.WriteLine(" player,you lose");
    }else if(EnemyHp== 0)
    {
        Console.WriteLine("enemy you lose");
    }

}