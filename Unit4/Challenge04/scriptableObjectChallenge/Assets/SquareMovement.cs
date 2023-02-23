using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    public Rigidbody squareRigidBody;
   
    public int moveSpeed = 500;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        } 
        else if (Input.GetKeyDown(KeyCode.S) == true)
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        } 
        else if (Input.GetKeyDown(KeyCode.A) == true)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        } 
        else if (Input.GetKeyDown(KeyCode.D) == true)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
