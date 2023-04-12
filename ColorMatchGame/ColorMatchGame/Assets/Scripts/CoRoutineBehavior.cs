using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoRoutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    public bool canRun;

    private void Start()
    {
        startEvent.Invoke();
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

    }
    public void StartCounting()
    {
        Debug.Log("Counting");
        StartCoroutine(Counting());
    } 


    private IEnumerator Counting()
    {
     
        startCountEvent.Invoke();

        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }

        endCountEvent.Invoke();

      
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while(canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
  
    }

}
