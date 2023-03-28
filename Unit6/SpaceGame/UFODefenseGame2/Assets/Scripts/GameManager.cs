using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public OOBDestroy outOfBounds;
    public bool isGameOver;
    private GameObject GameOverText;

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {
            EndGame(); //start endgame
        }
        else
        {
            GameOverText.gameObject.SetActive(false); //Keep UI text (gameover) hidden
        }
    }

    void EndGame()
    {
        GameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; //freeze time
    }
       
}


