using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text score;

    // Use this for initialization
    void Start()
    {
        score.text = "FLAPS: " + PlayerPrefs.GetInt("High Score").ToString();
    }
}