using UnityEngine;
using UnityEngine.UI;
//**********************************вывод максимума в гейм овер

public class ScoreMax : MonoBehaviour
{

    public static int scoreMax;
    public static int scoreMaxGlobal1;
    Text textMax;

    void Awake()
    {

        textMax = GetComponent<Text>();
        Spawner.scoreMaxGlobalReestr = ScoreText.scoreMAX_seychas_vremennaya;
        scoreMax = ScoreText.scoreMAX_seychas;

    }

    void Start()
    {
        //MaxSave2();
        textMax.text = "Max:  " + scoreMax;
   
    }

    
       public void nullSave()
    {
        string key = "CATTRIS";
        PlayerPrefs.SetInt(key, 11);
        //PlayerPrefs.SetInt(key, ScoreText.scoreMaxGlobal);
        PlayerPrefs.Save();
    }


    public void MaxSave2()
    {
        string key = "CATTRIS";
        PlayerPrefs.SetInt(key, ScoreText.scoreMAX_seychas_vremennaya);
        //PlayerPrefs.SetInt(key, scoreMaxGlobal);
        PlayerPrefs.Save();
    }
}
