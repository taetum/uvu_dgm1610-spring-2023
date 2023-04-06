using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }
    // Start is called before the first frame update
    private void Start()
    {
        startEvent.Invoke();
    }

    // Update is called once per frame
    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
