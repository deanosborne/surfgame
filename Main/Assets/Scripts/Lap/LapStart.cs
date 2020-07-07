using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapStart : MonoBehaviour
{

    public bool timer;
    public LapTimeManager ltm;
    public LapComplete lc;

    public Transform spawn;
    GameObject player;

    void Start()
    {
        
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ltm.timer = true;
            lc.finished = false;
        }
    }
}
