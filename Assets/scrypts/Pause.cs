using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPaused;
    public GameObject Pause1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        { 
            if(isPaused)
                ResumeGame();
            else
                PauseGame();

        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        Pause1.SetActive(true);
        isPaused= true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        Pause1.SetActive(false);
        isPaused= false;
    }
}
