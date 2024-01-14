using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public int currentScore;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;
    public void ChangeScore(int points)
    {
        currentScore += points;
        scoreText.text = currentScore.ToString();
    }

    public void HighScoreUpdate()
    {
        // jau turi highScore
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            // ar naujas HighScore didesnis uz senesni
            if (currentScore > PlayerPrefs.GetInt("SavedHighScore"))
            {
                //naujas HighScore
                PlayerPrefs.SetInt("SavedHighScore", currentScore);
            }
        }
        else
        {
            //jei nera HighScore
            PlayerPrefs.SetInt("SavedHighScore", currentScore);
        }

        //atnaujname TMP
        finalScoreText.text = currentScore.ToString();
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();

    }

}
