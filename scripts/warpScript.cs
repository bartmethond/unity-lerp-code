using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpScript : MonoBehaviour
{
    public cameraMovement cameraMove;
    public overSeeer overLord;
    public float YScale;
    public Light bright;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(overLord.timeDisplay);
        Debug.Log("modulo 1 = " + overLord.timeDisplay % 1);
        if(overLord.timeDisplay % 1 < 0.2)
        {
            YScale = 1;
        }
        else
        {
            YScale = 2;
        }
        float currentY = transform.localScale.y;
        float percentage = overLord.timeDisplay % 1;
        float lerpedY = Mathf.Lerp(currentY, YScale, percentage);
        transform.localScale = new Vector3(1, lerpedY, 1);
        bright.intensity = 2.1f - lerpedY;
    }
}
