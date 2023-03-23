using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowEffect : MonoBehaviour
{
    public float rainbowSpeed;
    private float hue;
    private float saturation;
    private float brightness;
    private MeshRenderer rainbowMesh;

    // Start is called before the first frame update
    void Start()
    {
        rainbowMesh = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

       

            Color.RGBToHSV(rainbowMesh.material.color, out hue, out saturation, out brightness);
            hue += rainbowSpeed / 10000;
            if (hue >= 1)
            {
                hue = 0;
            }
            saturation = 0.5f;
            brightness = 1;
            rainbowMesh.material.color = Color.HSVToRGB(hue, saturation, brightness);
         
    }
}
