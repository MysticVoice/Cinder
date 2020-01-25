using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpCam : MonoBehaviour
{
    public GameObject cameraTarget;
    public float lerpFactor = 10;

    void LateUpdate()
    {
        Vector3 pos = Vector3.Lerp(transform.position, cameraTarget.transform.position, lerpFactor*Time.deltaTime);
        pos.z = transform.position.z;
        transform.position = pos;
    }
}
