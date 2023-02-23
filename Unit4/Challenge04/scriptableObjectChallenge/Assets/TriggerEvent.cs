using Newtonsoft.Json.Bson;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    

    public UnityEvent triggerEnterEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        
    }

}
