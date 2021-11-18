using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{

    private Rigidbody2D m_body;
    
    [Range(0, 10)]
    public float speed = 1f;

    public int health = 3;

    private void Awake()
    {
        m_body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get both axis

        float translationX = Input.GetAxis("Horizontal");
        float translationY = Input.GetAxis("Vertical");

        // Create a Vector2 from both axis
        Vector2 translation = new Vector2(translationX, translationY);

        // Apply the velocity to the Rigidbody2D
        m_body.velocity = translation * speed;


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("OnCollisionEnter2D");

        if (col.gameObject.CompareTag("BulletEnemy"))
        {
            health--;
            if (health==0)
            {
                Destroy(gameObject);
            }
            // col.gameObject.GetComponent<BulletEnemy>().Die();
            Destroy(col.gameObject);
        } 
        
        if (col.gameObject.CompareTag("Enemy"))
        {
            health--;
            if (health==0)
            {
                Destroy(gameObject);
            }
        } 
    }
    
}
