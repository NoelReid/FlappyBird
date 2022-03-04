using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//use UI elements, like text, in unity
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    //declare a text UI element to be assigned in Unity
    public Text CountText;
    //create a variable that keeps track of the actual score 
    public static int count;

    void Start()
    {
        //deletes your saved score when level starts over setting it back to 0
        PlayerPrefs.DeleteAll();
        //set the "count" to 0
        count = PlayerPrefs.GetInt("High Score", 0);
        //this runs the SetCountText() function that we will write below
        SetCountText();
    }
    void Update()
    {
        //if the "Fire1 input" is pressed
        if (Input.GetButtonDown("Fire1"))
        {
            //1 is added to the variable "count" that we declared above
            count = count + 1;
            //set the high score to the new value of "count"
            PlayerPrefs.SetInt("High Score", count);
            //execute the SetCountText() function that we wrote below
            SetCountText();
        }
    }


    //display the score dynamically as it changes
    void SetCountText()
    {
        //change the value of the UI Text object 
        CountText.text = "Flaps: " + count.ToString();
    }
}
