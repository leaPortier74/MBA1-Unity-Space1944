using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
