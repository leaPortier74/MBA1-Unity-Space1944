using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public int health = 3;

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
