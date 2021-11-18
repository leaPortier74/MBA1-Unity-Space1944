using UnityEngine;

public class BulletEnemy : MonoBehaviour
{

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