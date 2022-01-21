using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//*************************************вывод текущего итога в геймовер
public class ScoreItog : MonoBehaviour
{

    public static int textItog;
    public static Text text_itog1;
    
    void Awake()
    {
        text_itog1 = GetComponent<Text>();
        //text_max_score = GetComponent<Text>();
    }

    void Update()
    {



        //***************
        textItog = ScoreText.score;
        text_itog1.text = "Score:" + textItog;
        //***************


    }


    
    void Start()
    {
        
    }

    
}
