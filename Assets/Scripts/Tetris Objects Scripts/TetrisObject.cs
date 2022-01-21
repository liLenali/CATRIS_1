using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class TetrisObject : MonoBehaviour
{
    float lastFall = 0f;
    //float fall = 0f;
    public float speedFalling = 1;



    void Start()
    {
        Screen.SetResolution(480, 800, false);

        if (!IsValidGridPosition())
        {
           
            MaxSave3();
            Debug.Log("GAME OVER");
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");


        }

    }

    
    void Update()
    {

        if (!GameplayController.isPaused)
        {

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-1, 0, 0);

                if (IsValidGridPosition())
                {
                    UpdateMatrixGrid();
                }
                else
                {
                    transform.position += new Vector3(1, 0, 0);
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position += new Vector3(1, 0, 0);

                if (IsValidGridPosition())
                {
                    UpdateMatrixGrid();
                }
                else
                {
                    transform.position += new Vector3(-1, 0, 0);
                }
            }

            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Rotate(new Vector3(0, 0, -90));
                if (IsValidGridPosition())
                {
                    UpdateMatrixGrid();
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 90));
                }
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - lastFall >= 1)
            {
                transform.position += new Vector3(0, -1, 0);
                    
                
                if (IsValidGridPosition())
                {
                    UpdateMatrixGrid();
                }
                else {
                    transform.position += new Vector3(0, 1, 0);
                    MatrixGrid.DeleteWholeRows();
                    FindObjectOfType<Spawner>().SpawnRandom();

                    enabled = false;

                }
                lastFall = Time.time;
            }

        


        //******
        else if (Input.GetKeyDown(KeyCode.Space) /*|| Time.time - fall >= speedFalling*/)
        {
                {
                    transform.position += new Vector3(0, -1, 0);
                    //fall = Time.time;
                }

                if (IsValidGridPosition())
            {
                UpdateMatrixGrid();
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                MatrixGrid.DeleteWholeRows();
                FindObjectOfType<Spawner>().SpawnRandom();

                enabled = false;

            }
            lastFall = Time.time;
        }

     }


        //*****


    }

  
    bool IsValidGridPosition()
    {
        foreach (Transform child in transform) 
        {
            Vector2 v = MatrixGrid.RoundVector(child.position);

            if (!MatrixGrid.IsInsideBorder(v))
                return false;
            if (MatrixGrid.grid[(int)v.x, (int)v.y] != null && MatrixGrid.grid[(int)v.x, (int)v.y].parent != transform)
                return false;

        }
        return true;
    }

    void UpdateMatrixGrid() 
    {
        for (int y = 0; y < MatrixGrid.column; ++y) 
        {
            for (int x = 0; x < MatrixGrid.row; ++x) 
            {
                if (MatrixGrid.grid[x, y] != null) 
                {
                    if (MatrixGrid.grid[x, y].parent == transform) 
                    {
                        MatrixGrid.grid[x, y] = null;
                    }
                }
            }
        }

        foreach (Transform child in transform) 
        {
            Vector2 v = MatrixGrid.RoundVector(child.position);
            MatrixGrid.grid[(int)v.x, (int)v.y] = child;

        }

    }


    public void MaxSave3()
    {
        string key = "CATTRIS";
        PlayerPrefs.SetInt(key, ScoreText.scoreMAX_seychas_vremennaya);
        //PlayerPrefs.SetInt(key, scoreMaxGlobal);
        PlayerPrefs.Save();
    }

}
