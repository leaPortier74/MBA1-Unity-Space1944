using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public EnemyData Data{ get; private set; }

    private SpriteRenderer m_Renderer;
    
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
            col.gameObject.GetComponent<Bullet>().Damage();
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
