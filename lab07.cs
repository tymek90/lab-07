class Player
{
    public string Imie { get; }
    public int Hp { get; set; }
    public int MaksymalneHp { get; }

    public Player(string imie, int maksymalneHp)
    {
        Imie = imie;
        MaksymalneHp = maksymalneHp;
        Hp = maksymalneHp;
    }

    public void TakeDamage(int obrazenia)
    {
        Hp -= obrazenia;

        if (Hp < 0)
        {
            Hp = 0;
        }
    }

    public void Heal(int leczenie)
    {
        Hp += leczenie;

        if (Hp > MaksymalneHp)
        {
            Hp = MaksymalneHp;
        }
    }

    public bool IsAlive()
    {
        return Hp > 0;
    }
}
