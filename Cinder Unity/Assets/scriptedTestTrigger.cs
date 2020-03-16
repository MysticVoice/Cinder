using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptedTestTrigger : MonoBehaviour
{
    public GameObject g;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        g.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        g.SetActive(false);
    }
}
