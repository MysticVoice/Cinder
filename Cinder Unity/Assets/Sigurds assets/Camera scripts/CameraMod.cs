using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMod : MonoBehaviour
{
    public int newFov;

    public float multiplier;

    public float endTime;

    private bool isLerping = false;

    private void Update()
    {
        if (isLerping)
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, newFov, Time.deltaTime * multiplier);
        }  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(Camera.main.fieldOfView == newFov)
            {
                return;
            } 
            isLerping = true;
            Invoke("EndLerp", endTime);
        }
    }


    private void EndLerp()
    {
        isLerping = false;
        Camera.main.fieldOfView = newFov;
    }
}
