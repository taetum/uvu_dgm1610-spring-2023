using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOBDestroy : MonoBehaviour
{

    public float topBounds = 30.0f;

    public float bottomBounds = -10.0f;


  /*  void Awake()
    {
        //  Time.timeScale = 1.0f;
    } */

    // Start is called before the first frame update
    void Start()
    {

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
           // Debug.Log("Game Over.");
            Destroy(gameObject);

            //   Time.timeScale = 0;
        }
    }
}
