using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    
    public bool Playing { get; private set; } = false;
    
    //public ScoreManager Score { get; private set; }
    
    public PlaneController Plane { get; private set; }

    public AudioManager Audio { get; private set; }
    
    public EnemiesManager Enemies { get; private set; }

    public BulletManager Bullet { get; private set; }
    
    public TimeManager Timer { get; private set; }


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

        Plane = GetComponent<PlaneController>();
        //Score = GetComponent<ScoreManager>();
        Audio = GetComponent<AudioManager>();
        Enemies = GetComponent<EnemiesManager>();
        Bullet = GetComponent<BulletManager>();
        Timer = GetComponent<TimeManager>();
        Timer.Completed += TimeCompletedHandler;
    }

    
    public void StartGame()
    {
        Playing = true;
        Audio.PlayMainTheme();
        Enemies.StartSpawning();
        Bullet.StartSpawning();
        //Score.Reset();
        Timer.Reset();
    }
    
    public void StopGame()
    {
        Playing = false;
        Plane.health = 0;
        Enemies.StopSpawning();
        Bullet.StopSpawning();
        //Score.SubmitScore(Score.Value);
    }
    
    private void TimeCompletedHandler(object sender, EventArgs e)
    {
        StopGame();
    }
    
    

}
