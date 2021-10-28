using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int Value { get; private set; }

    private GameManager m_Game;

    private const string BEST = "bestScore";
    
    public int Best
    {
        get => PlayerPrefs.GetInt(BEST, 0);
        set => PlayerPrefs.SetInt(BEST, value);
    }
    
    private void Awake()
    {
        m_Game = GameManager.Instance;
    }


    public void SubmitScore(int score)
    {
        if (score > Best)
        {
            Best = score;
        }
    }

    public void Reset()
    {
        Value = 0;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
