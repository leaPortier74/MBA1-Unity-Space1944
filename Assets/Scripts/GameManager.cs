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
    }
    
    public void StartGame()
    {
        Playing = true;
        //Audio.PlayMainTheme();
        Enemies.StartSpawning();
        //Score.Reset();
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
