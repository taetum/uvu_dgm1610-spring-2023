using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public IDScript idObj;
    private IDScript otherID;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    private AudioSource matcherAudio;
    public AudioClip matchAudio, noMatchAudio;

    private void Start()
    {
       matcherAudio = GetComponent<AudioSource>();
    }
    private IEnumerator OnTriggerEnter(Collider other)
    {

        var tempObj = other.GetComponent<IdContainerBehavior>();
        if (tempObj == null)
            yield break;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
            matcherAudio.PlayOneShot(matchAudio, 1.0f);
            
        }
        else
        {
            noMatchEvent.Invoke();
            matcherAudio.PlayOneShot(noMatchAudio, 1.0f);
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}

