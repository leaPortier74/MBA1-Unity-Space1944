using System;

public class EnemyEvent : EventArgs
{
    public Enemy Enemy{ get; private set; }

    
    public EnemyEvent(Enemy enemy)
    {
        Enemy = enemy;
    }
}
