using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{

    public float seconds = 1;
    private WaitForSeconds wfsObj;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        yield return wfsObj;
        Destroy(gameObject);
    }

}
