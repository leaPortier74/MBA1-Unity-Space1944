using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("OnCollisionEnter2D");

        if (col.gameObject.CompareTag("BulletEnemy"))
        {
            //col.gameObject.GetComponent<BulletEnemy>().Die();
            Destroy(col.gameObject);
        } 
        if (col.gameObject.CompareTag("Bounds"))
        {
            Destroy(gameObject);
        }
    }
    

}
