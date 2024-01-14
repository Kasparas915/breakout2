using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenblocks : MonoBehaviour
{
    public int PointValue;
    public Score scoreManager;
    public int greenlives;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        greenlives -= 1;
        if (greenlives > 0)
        {
            
        }
        else
        {
            scoreManager.ChangeScore(PointValue);
            Destroy(gameObject);
        }

    }
}
