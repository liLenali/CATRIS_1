using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

   // public static int scoreMaxGlobalReestr;
   // public static int scoreReestr;
    public void PlayGame() {
       // MaxLoad();
        Application.LoadLevel("Gameplay");

    }

    public void ExitGame()
    {
        //Time.timeScale = 1f;
        //Application.LoadLevel("MainMenu"); 

        //scoreReestr = ScoreText.score;
        MaxSave();
        Application.Quit();
    }

    public void MaxSave()
    {
        string key = "CATTRIS";
        //PlayerPrefs.SetInt(key, scoreReestr);
        PlayerPrefs.SetInt(key, Spawner.scoreMaxGlobalReestr);
        PlayerPrefs.Save();
    }

    //private void MaxLoad()
    //{
        //string key = "CATTRIS";
       // if (PlayerPrefs.HasKey(key))
       // {
          //  scoreMaxGlobalReestr = PlayerPrefs.GetInt(key);
        //}

    //}

}
