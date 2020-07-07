using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public bool finished;

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public LapTimeManager ltm;


    public float RawTime;

    GameObject player;

    public Transform spawn;
    public StrafeMovement strafemovement;

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
                finished = true;
        }
            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.RawTime <= RawTime)
            {

                
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                }

                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
                }

            ScoringSystem.score += 50;

        }

            PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MilliCount = 0;
            LapTimeManager.RawTime = 0;

            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    

}