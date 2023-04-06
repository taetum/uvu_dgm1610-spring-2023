using UnityEngine;
using UnityEngine.Events;

public class IdContainerBehavior : MonoBehaviour
{
    public IDScript idObj;
    public UnityEvent startEvent;
    private void Start()
    {
        startEvent.Invoke();
    }
}