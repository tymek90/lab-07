Player player = new Player("Maciuś", 100, 25);
Player player2 = new Player("Tymek", 100, 25);
Enemy goblin = new Enemy("Goblin", 30, 8);
Enemy nietoperz = new Enemy("Nietoperz", 25, 9);

Console.WriteLine($"{player.Name} spotyka {goblin.Name}.");

goblin.TakeDamage(12);
Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

if (goblin.IsAlive())
{
    player.TakeDamage(goblin.Damage);
    Console.WriteLine($"{player.Name} ma {player.Health} HP.");
}
else
{
    Console.WriteLine("Przeciwnik został pokonany.");
}

Console.WriteLine($"{player2.Name} spotyka {nietoperz.Name}.")

player2.TakeDamage(33);
Console.WriteLine($"{player2.Name} ma {player2.Health} HP.");

if(player2.IsAlive())
{
    nietoperz.TakeDamage(player2.Damage);
    Console.WriteLine($"{nietoperz.Name} ma {nietoperz.Health} HP.");
}
else
{
    Console.WriteLine("Gracz drugi zostal zabity.");
}