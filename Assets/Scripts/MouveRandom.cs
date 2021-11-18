using UnityEngine;

public class MouveRandom : MonoBehaviour
{
    private Rigidbody2D m_body;

    void Awake() 
    {
        m_body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        int x = Random.value < 0.5f ? 1 : -1;
        int y = Random.value < 0.5f ? 1 : -1;
        m_body.velocity = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
