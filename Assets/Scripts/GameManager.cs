using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    
    private bool Playing = false;
    
    public ScoreManager Score { get; private set; }

    public AudioManager Audio { get; private set; }
    
    public EnemiesManager Enemies { get; private set; }

    public BulletManager Bullet { get; private set; }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        Score = GetComponent<ScoreManager>();
        Audio = GetComponent<AudioManager>();
        Enemies = GetComponent<EnemiesManager>();
        Bullet = GetComponent<BulletManager>();
    }

    
    public void StartGame()
    {
        Playing = true;
        //Audio.PlayMainTheme();
        Enemies.StartSpawning();
        Bullet.StartSpawning();
        //Score.Reset();
    }
    
    public void StopGame()
    {
        Playing = false;
        Enemies.StopSpawninig();
        Bullet.StartSpawning();
        //Score.SubmitScore(Score.Value);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

}
