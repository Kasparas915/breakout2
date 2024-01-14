using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesManager : MonoBehaviour
{
    public int currentLives = 5;
    public GameObject GameOver1;
    public TMP_Text livesText;

    public Score scoreManager;

    public void LoseLife()
    {
        currentLives -= 1;
        livesText.text = currentLives.ToString();
        if(currentLives <= 0)
        {
            Time.timeScale = 0;
            GameOver1.SetActive(true);

            //iskvieciamas HighScoreUpdate
            scoreManager.HighScoreUpdate();
        }
    }
}
