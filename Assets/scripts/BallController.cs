using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D ballRb;
    public float minVelocity;
    public float maxVelocity;
    public float minY;


    public LivesManager livesManager;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent < Rigidbody2D >();

        ballRb.velocity = new Vector2(0, -minVelocity);
    }

    // Update is called once per frame
    void Update()
    {
      if(ballRb.velocity.magnitude > maxVelocity)
        {
            ballRb.velocity = Vector2.ClampMagnitude(ballRb.velocity, maxVelocity);
        }

      if(ballRb.velocity.magnitude < minVelocity)
        {
            if(ballRb.velocity.y < 0)
            {
                ballRb.velocity = new Vector2(ballRb.velocity.x, -minVelocity);
            }

            if (ballRb.velocity.y > 0)
            {
                ballRb.velocity = new Vector2(ballRb.velocity.x, minVelocity);
            }
        }

      if(transform.position.y < minY)
        {
            livesManager.LoseLife();
            transform.position = Vector2.zero;
            ballRb.velocity = new Vector2(0, -minVelocity);
        }
    }
}
