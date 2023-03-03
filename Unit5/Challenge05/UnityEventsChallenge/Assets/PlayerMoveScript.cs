using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");
        
        // direction movement
        if (Input.GetKeyDown(KeyCode.W) == true) 
        {
            transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        } else if (Input.GetKeyDown(KeyCode.S) == true)  
        {
            transform.localRotation = Quaternion.Euler(0f, 0f, -180f);
        } else if (Input.GetKeyDown(KeyCode.A) == true)
        {
            transform.localRotation = Quaternion.Euler(0f, 0f, -270f);
        } else if (Input.GetKeyDown(KeyCode.D) == true)
        {
           transform.localRotation = Quaternion.Euler(0f, 0f, -90f);
        }

    }

}
