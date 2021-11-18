using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public EnemyData Data{ get; private set; }

    private SpriteRenderer m_Renderer;
    
    public int health = 3;
    
    public bool autoDestroy = true;
    
    private void Awake()
    {
        m_Renderer = GetComponent<SpriteRenderer>();
    }

    public void LoadData(EnemyData data)
    {
        Data = data;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("OnCollisionEnter2D");

        if (col.gameObject.CompareTag("Bullet"))
        {
            health--;
            if (health==0)
            {
                Destroy(gameObject);
            }
            // col.gameObject.GetComponent<Bullet>().Die();
            Destroy(col.gameObject);
        } 
        
        if (col.gameObject.CompareTag("Player"))
        {
            health--;
            if (health==0)
            {
                Destroy(gameObject);
            }
        } 
    }
}
