public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level {get; set;}
    public int Experiance {get; set;}

    public Player(string name, int maxHealth, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = 1;
        Experiance =0;

    }

    public void TakeDamage(int damage)
    {
        if(damage<=0) return;
        if(!IsAlive()) return;

        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }

    }

    public void Heal(int amount)
    {
        if(amount<=0) return;
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void AddExperiance(int amount)
    {
        Experiance += amount;
        if(Experiance >=100)
        {
            Level++;
            Experiance -=100;
            MaxHealth += 20;
            Health = MaxHealth;
        }
    }
}
