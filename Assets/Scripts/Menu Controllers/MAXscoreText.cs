using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//******************************************вывод максимума на игровой панели
public class MAXscoreText : MonoBehaviour
{
    public static int scoreMAX1;
    //public static int scoreMaxGlobal;
    Text textMAX1;
    
    void Awake()
    {
        textMAX1 = GetComponent<Text>();
      
    }

    void Start()
    {
        scoreMAX1 = ScoreText.scoreMAX_seychas;
       textMAX1.text = "MAX: " + scoreMAX1;
        Spawner.scoreMaxGlobalReestr = ScoreText.scoreMAX_seychas_vremennaya;
    }


    
}
