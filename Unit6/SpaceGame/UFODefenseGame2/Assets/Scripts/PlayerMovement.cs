using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject laserbolt;


    // Update is called once per frame
    void Update()
    {
        //set horizontal input to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep player in play field
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // creates a laser bolt at blaster transform position, maintaining object's rotation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserbolt, blaster.transform.position, laserbolt.transform.rotation);
        }
    }

    //delete any object w a trigger that hits the player
    /*
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    } */
    
}
