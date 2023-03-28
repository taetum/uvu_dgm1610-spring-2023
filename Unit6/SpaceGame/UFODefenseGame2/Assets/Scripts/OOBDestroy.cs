using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOBDestroy : MonoBehaviour
{
    public GameObject GameManager;
    public GameManager gameManager;
    public float topBounds = 30.0f;

    public float bottomBounds = -10.0f;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBounds)
        {
            Destroy(gameObject);
            GameEnd();
        }
    }
    void GameEnd()
    {
        if (gameObject.transform.position.z <bottomBounds)
        {
            if(gameObject.tag == "Enemy")
            {
                Debug.Log("Gameover");
                gameManager.isGameOver = true;
            }
           
        }
    } 
}
