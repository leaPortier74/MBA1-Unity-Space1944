using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    
    public bool Playing { get; private set; } = false;
    
    public ScoreManager Score { get; private set; }

    public AudioManager Audio { get; private set; }
    
    public EnemiesManager Enemies { get; private set; }

    public BulletManager Bullet { get; private set; }

    public PlaneController Player;

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
        Player = GetComponent<PlaneController>();
    }

    
    public void StartGame()
    {
        Playing = true;
        //Audio.PlayMainTheme();
        Enemies.StartSpawning();
        //Score.Reset();
    }

    public void PlayerDie()
    {
        if (Player)
        {
            StopGame();
        }
    }
    
    private void StopGame()
    {
        Playing = false;
        Enemies.StopSpawninig();

        //Score.SubmitScore(Score.Value);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Enemies.StartSpawning();
        Bullet.StartSpawning();
        
    }

}
