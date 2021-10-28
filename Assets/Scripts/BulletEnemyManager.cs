using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyManager : MonoBehaviour
{

    private List<GameObject> m_Bullet = new List<GameObject>();

    public GameObject spawner;

    public GameObject bulletPrefab;

    [Range(0, 10)] public float delay = 5f;

    private Coroutine m_SpawnRoutine;
    
    public BulletEnemyManager BulletEnemy { get; private set; }
    
    public void StartSpawning()
    {
        m_SpawnRoutine = StartCoroutine(SpawnRoutine());
    }

    public void StopSpawninig()
    {
        StopCoroutine(m_SpawnRoutine);
    }

    IEnumerator SpawnRoutine()
    {
        Spawn();
        yield return new WaitForSeconds(delay);
        StartSpawning();
    }
    
    private void Spawn()
    {

        GameObject bullet = Instantiate(bulletPrefab, spawner.transform.position, Quaternion.identity);

        m_Bullet.Add(bullet);
    }

    private void Awake()
    {
        BulletEnemy = GetComponent<BulletEnemyManager>();
    }


    // Start is called before the first frame update
    void Start()
    {
        BulletEnemy.StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}