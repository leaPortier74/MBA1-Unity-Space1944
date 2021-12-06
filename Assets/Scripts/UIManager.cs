using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private GameManager m_Game;
    
    //public TextMeshProUGUI score;
    
    //public TextMeshProUGUI best;
    
    public TextMeshProUGUI time;

    public Button startGame;

    private void Awake()
    {
        m_Game = GameManager.Instance;
    }

    private void Update()
    {
        //score.text = "Score : " + m_Game.Score.Value;
        //best.text = "Best : " + m_Game.Score.Best;
        time.text = m_Game.Timer.Formatted;
        startGame.gameObject.SetActive(!m_Game.Playing);
    }
}