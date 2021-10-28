using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private SpriteRenderer m_Renderer;
    
    public BulletData Data{ get; private set; }

    private void Awake()
    {
        m_Renderer = GetComponent<SpriteRenderer>();
    }
    
    public void LoadData(BulletData data)
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
