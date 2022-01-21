using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] tetrisObjects;

    public static int scoreMaxGlobalReestr;
    public static int scoreReestr;

    void Awake()
    {
        //MaxLoad();

        
    }

    void Start()
    {
        MaxLoad();
        scoreReestr = scoreMaxGlobalReestr;
        Screen.SetResolution(480, 800, false);
        SpawnRandom();

       

    }

           public void SpawnRandom() 
        {
        int index = Random.Range(0,tetrisObjects.Length);
        Instantiate(tetrisObjects[index], transform.position, Quaternion.identity);


        }


 
    private void MaxLoad()
    {
    string key = "CATTRIS";
    if (PlayerPrefs.HasKey(key))
     {
      scoreMaxGlobalReestr = PlayerPrefs.GetInt(key);
    }

    }

}
