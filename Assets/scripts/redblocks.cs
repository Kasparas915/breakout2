using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redblocks : MonoBehaviour
{
    public int PointValue;
    public Score scoreManager;
    public int redlives;

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
        redlives -= 1;
        if (redlives > 0)
        {
            
        }
        else
        {
            scoreManager.ChangeScore(PointValue);
            Destroy(gameObject);
        }

    }
}

