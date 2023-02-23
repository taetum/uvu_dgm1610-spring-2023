using UnityEngine;
using UnityEngine.Events;
public class ScriptTriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
