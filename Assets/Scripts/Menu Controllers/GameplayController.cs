using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{

    [SerializeField]
    private GameObject pausePanel;

    public static int scoreMAX2;
    public static int scoreReestr1;

    public static bool isPaused = false;

    //public GameObject modalWindow;

    void Awake()
    {
        pausePanel.SetActive(false);
    }

    public void PauseGame()
    {

        
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        isPaused = true;
        // modalWindow.SetActive(true);


    }

    public void ResumeGame()
    {

        

        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        isPaused = false;
    }


    public void QuitGame()
    {
              
        Application.Quit();
    }

    public void MaxSave1()
    {
        string key = "CATTRIS";
        PlayerPrefs.SetInt(key, Spawner.scoreMaxGlobalReestr);
        PlayerPrefs.Save();
    }

}
