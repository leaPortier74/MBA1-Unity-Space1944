using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{

    private int health = 5;
    private SpriteRenderer m_Renderer;
    
    public BulletData Data{ get; private set; }
    
    [Range(0, 8)]
    public float speed = 1f;

    private void Awake()
    {
        m_Renderer = GetComponent<SpriteRenderer>();
    }
    
    public void LoadData(BulletData data)
    {
        Data = data;

    }
    
    void OnBecameInvisible() {
        Destroy(gameObject);
    }
    
    public void Die()
    {
        Destroy(gameObject);
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("OnCollisionEnter2D");

        if (col.gameObject.CompareTag("Bullet"))
        {
            //col.gameObject.GetComponent<Bullet>().Die();
            Destroy(col.gameObject);
        } 
        if (col.gameObject.CompareTag("Bounds"))
        {
            Destroy(gameObject);
        }
    }

}