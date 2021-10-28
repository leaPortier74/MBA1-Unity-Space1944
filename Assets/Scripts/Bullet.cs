using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
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
    
    public void Damage()
    {
        Destroy(gameObject);
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("OnCollisionEnter2D");

        if (col.gameObject.CompareTag("BulletEnemy"))
        {
            col.gameObject.GetComponent<BulletEnemy>().Damage();
            Die();
        } 
        
        if (col.gameObject.CompareTag("Bounds"))
        {
            Die();
        }
    }
    
    void Die()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
