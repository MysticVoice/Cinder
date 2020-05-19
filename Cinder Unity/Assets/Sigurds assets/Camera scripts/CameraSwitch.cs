using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public bool newCam = false;
    public bool oldCam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(newCam = false)
        {
            oldCam = false;
            newCam = true;
        }
    }
}
