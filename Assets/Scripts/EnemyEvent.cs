using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEvent : MonoBehaviour
{
    public Enemy Enemy{ get; private set; }

    
    public EnemyEvent(Enemy enemy)
    {
        Enemy = enemy;
    }
}
