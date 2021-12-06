using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BulletManager : MonoBehaviour
{

    private List<GameObject> m_Bullet = new List<GameObject>();

    public Transform container;

    public Transform spawner;

    public GameObject bulletPrefab;

    [Range(0, 10)] public float delay = 5f;

    public List<BulletData> bulletDataList;

    private Coroutine m_SpawnRoutine;
    
    public void StartSpawning()
    {
        m_SpawnRoutine = StartCoroutine(SpawnRoutine());
    }

    public void StopSpawning()
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
        if (!spawner) return;
        
        GameObject bullet = Instantiate(bulletPrefab, spawner.position, Quaternion.identity);
        bullet.transform.parent = container.transform;
        
        BulletData data = getRandomBulletData();

        m_Bullet.Add(bullet);
    }

    private BulletData getRandomBulletData()
    {
        int index = Random.Range(0, bulletDataList.Count);
        return bulletDataList[index];
    }

    private void OnDestroy()
    {
        StopCoroutine(m_SpawnRoutine);
    }
    

}
