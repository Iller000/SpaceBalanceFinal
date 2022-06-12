using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void PlayGame()
    {
        ScoreManager.totalScore = 0;
        ScoreManager.balanceScore = 0;
        CollectorBalance._score = 0;
        SceneManager.LoadScene(1);
        
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
