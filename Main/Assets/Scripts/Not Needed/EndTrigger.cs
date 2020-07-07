using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    GameObject player;
    public Transform spawn;
    public StrafeMovement strafemovement;
    public LapTimeManager ltm;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider zz)
    {
        if (zz.gameObject.tag == "Player")
        {
            strafemovement.Freeze();
            player.transform.position = spawn.transform.position;
            strafemovement.Unfreeze();
            ltm.timer = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
