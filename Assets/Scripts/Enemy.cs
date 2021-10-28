using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public EnemyData Data{ get; private set; }

    private SpriteRenderer m_Renderer;
    
    private void Awake()
    {
        m_Renderer = GetComponent<SpriteRenderer>();
    }

    public void LoadData(EnemyData data)
    {
        Data = data;

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
