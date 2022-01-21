using UnityEngine.UI;
using UnityEngine;


//****************текущий подсчет очков в игровом меню
public class ScoreText : MonoBehaviour
{

    public static int score;

    public static int scoreMAX_seychas;
    public static int scoreMAX_seychas1;

    public static int scoreMAX_seychas_vremennaya;
    Text text;
    
    
    void Awake()
    {

        MaxLoad3();

        text = GetComponent<Text>();
        score = 0;
        scoreMAX_seychas = Spawner.scoreMaxGlobalReestr;
        scoreMAX_seychas1 = Spawner.scoreMaxGlobalReestr;

    }

    void Update()
    {
        text.text = "Score:" + score;


        if (score > scoreMAX_seychas1)
        {
            scoreMAX_seychas1 = score;
            
        }
        scoreMAX_seychas_vremennaya = scoreMAX_seychas1;
    }



    private void MaxLoad3()
    {
        string key = "CATTRIS";
        if (PlayerPrefs.HasKey(key))
        {
            Spawner.scoreMaxGlobalReestr = PlayerPrefs.GetInt(key);
        }

    }








}
