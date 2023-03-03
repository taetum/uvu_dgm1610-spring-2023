using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletBehaviorScript : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public UnityEvent triggerEnterEvent;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        triggerEnterEvent.Invoke();
    }
}
