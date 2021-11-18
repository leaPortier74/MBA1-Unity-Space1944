using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemiesManager : MonoBehaviour
{

    private int nbEnemies;

    private List<Enemy> m_Enemy = new List<Enemy>();
    
    public Transform container;
    
    public Transform spawner;

    public Enemy enemyPrefab;
    
    public List<EnemyData> enemyDataList;
    
    [Range(0,10)]
    public float delay = 5f;

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
        Debug.Log("in Spawn");
        if ( nbEnemies < 10)
        {
            Debug.Log("in nbEnemies");
            Enemy enemy = Instantiate(enemyPrefab, spawner.position, Quaternion.identity);
            enemy.transform.parent = container.transform;
    
            EnemyData data = getRandomEnemyData();

            m_Enemy.Add(enemy);
            
            nbEnemies++;

        }
        
    }

    private EnemyData getRandomEnemyData()
    {
        int index = Random.Range(0, enemyDataList.Count);
        return enemyDataList[index];
    }
    
}
