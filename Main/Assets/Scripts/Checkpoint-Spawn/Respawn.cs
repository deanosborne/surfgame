using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{
    public LapTimeManager ltm;
    public StrafeMovement strafemovement;
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
            strafemovement.Freeze();
            player.transform.position = spawn.transform.position;
            strafemovement.Unfreeze();
            ltm.timer = false;
            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;
            LapTimeManager.RawTime = 0;
            lc.HalfLapTrig.SetActive(true);
            lc.LapCompleteTrig.SetActive(true);
        }
    }
}
