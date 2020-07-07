using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int score;
   

    void Start ()
    {
        score = PlayerPrefs.GetInt ("Score");
    }

    void Update()
    {
            scoreText.GetComponent<Text>().text = "Points: " + score;
            PlayerPrefs.SetInt("Score", score);
    }


}
