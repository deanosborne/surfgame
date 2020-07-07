using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin2 : MonoBehaviour
{
    GameObject player;

    public Transform spawn;
    public StrafeMovement strafemovement;
    public LapTimeManager ltm;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            strafemovement.Freeze();
            player.transform.position = spawn.transform.position;
            strafemovement.Unfreeze();
            ltm.timer = false;
        }
    }
}
