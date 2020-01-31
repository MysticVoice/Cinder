using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpCam : MonoBehaviour
{
    public GameObject cameraTarget;
    public float lerpFactor = 10;

    void LateUpdate()
    {
        Vector2 pos = Vector2.Lerp(transform.position, cameraTarget.transform.position, lerpFactor*Time.deltaTime);
        transform.position = new Vector3(pos.x,pos.y,-10);
    }
}
