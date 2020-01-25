using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int maxFlame = 200;
    PlayerData player;

    public int currentFlame => player.currentFlame;

    // Start is called before the first frame update
    void Start()
    {
        player = new PlayerData(maxFlame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
